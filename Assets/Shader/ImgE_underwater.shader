Shader "Hidden/ImgE_underwater"
{
	Properties
	{
		_MainTex( "Texture", 2D ) = "white" {}
		_NoiseScale( "Noise Scale", float ) = 1
		_NoiseFrequency( "Noise Frequency", float ) = 1
		_NoiseSpeed( "Noise Speed", float ) = 1
		_PixelOffset( "Pixel Offset", float ) = 0.01
	}
		SubShader
		{
			// No culling or depth
			Cull Off ZWrite Off ZTest Always

			Pass
			{
				CGPROGRAM

				#pragma vertex vert
				#pragma fragment frag

				#define TAU 6.28318530718

				#include "UnityCG.cginc"
				#include  "noiseSimplex.cginc"

				uniform float _NoiseScale, _NoiseFrequency, _NoiseSpeed, _PixelOffset;

				struct appdata
				{
					float4 vertex : POSITION;
					float2 uv : TEXCOORD0;
				};

				struct v2f
				{
					float2 uv : TEXCOORD0;
					float4 vertex : SV_POSITION;
					float4 sPos :TEXCOORD1;
				};

				v2f vert( appdata v )
				{
					v2f o;
					o.vertex = UnityObjectToClipPos( v.vertex );
					o.sPos = ComputeScreenPos( o.vertex );
					o.uv = v.uv;
					return o;
				}

				sampler2D _MainTex;

				fixed4 frag( v2f i ) : COLOR
				{
					float3 spos = float3( i.sPos.x, i.sPos.y, 0 ) * _NoiseFrequency;
					spos.z += _Time.x * _NoiseSpeed;

					float n = _NoiseSpeed * ( ( snoise( spos ) + 1 ) * .5 );
					float4 ndir = float4( cos( n * TAU ), sin( n * TAU ), 0, 0 );


					fixed4 col = tex2Dproj( _MainTex, i.sPos + normalize( ndir ) * _PixelOffset );
					return col;
				}
			ENDCG
		}
		}
}
