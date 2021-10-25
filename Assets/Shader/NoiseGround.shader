Shader "Custom/NoiseGround"
{
	Properties
	{
		_Tessellation( "Tesselation", Range( 0, 8 ) ) = 4
		_Color( "Color", Color ) = ( 1,1,1,1 )
		_MainTex( "Albedo (RGB)", 2D ) = "white" {}
		_NormalMap( "Normal Map", 2D ) = "bump" {}
		_Glossiness( "Smoothness", Range( 0,1 ) ) = 0.5
		_Metallic( "Metallic", Range( 0,1 ) ) = 0.0
		_NoiseScale( "Noise Scale", float ) = 1
		_NoiseFrequency( "Noise Frequency", float ) = 1
		_NoiseOffset( "Noise Offset", Vector ) = ( 0,0,0,0 )
	}
		SubShader
		{
			Tags { "RenderType" = "Opaque" }

			CGPROGRAM
			// Physically based Standard lighting model, and enable shadows on all light types
			#pragma surface surf Standard fullforwardshadows tessellate:tess vertex:vert
			#pragma require tessellation tessHW

			#pragma target 4.6

			#include "noiseSimplex.cginc"
			sampler2D _MainTex, _NormalMap;


			struct appdata
			{
				float4 vertex : POSITION;
				float3 normal : NORMAL;
				float4 tangent : TANGENT;
				float2 uv     : TEXCOORD0;
			};

			struct Input
			{
				float2 uv_MainTex;
			};

			float _Tessellation;
			half _Glossiness;
			half _Metallic;
			fixed4 _Color;

			float _NoiseScale, _NoiseFrequency;
			float4 _NoiseOffset;

			float4 tess()
			{
				return _Tessellation;
			}


			float applynoise( float3 v )
			{
				return _NoiseScale * snoise( float3( v.x + _NoiseOffset.x,
					v.y + _NoiseOffset.y,
					v.z + _NoiseOffset.z ) * _NoiseFrequency );
			}

			void vert( inout appdata_full v )
			{
				float3 v0 = v.vertex.xyz;
				float3 bitangent = cross( v.normal, v.tangent.xyz );
				float3 v1 = v0 + ( v.tangent.xyz * 0.01 );
				float3 v2 = v0 + ( bitangent.xyz * 0.01 );

				v0.xyz += ( ( applynoise( v0 ) + 1 ) * .5 ) * v.normal;
				v1.xyz += ( ( applynoise( v1 ) + 1 ) * .5 ) * v.normal;
				v2.xyz += ( ( applynoise( v2 ) + 1 ) * .5 ) * v.normal;

				float3 vnormal = cross( v2 - v0, v1 - v0 );
				v.normal = normalize( -vnormal );



				v.vertex.xyz = v0;
			}

			void surf( Input IN, inout SurfaceOutputStandard o )
			{
				// Albedo comes from a texture tinted by color
				fixed4 c = tex2D( _MainTex, IN.uv_MainTex ) * _Color;
				o.Albedo = c.rgb;
				// Metallic and smoothness come from slider variables
				o.Metallic = _Metallic;
				o.Smoothness = _Glossiness;
				o.Normal = UnpackNormal( tex2D( _NormalMap, IN.uv_MainTex ) );
			}
			ENDCG
		}
			FallBack "Diffuse"
}
