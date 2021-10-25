using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class ImgE_Underwater : MonoBehaviour {

	[SerializeField] private Material mat;
	[SerializeField] private Material matfog;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

	}

	private void OnRenderImage( RenderTexture src, RenderTexture dst ) {

		Graphics.Blit( src, dst, mat );
		//	Graphics.Blit( src, dst, matfog );
	}
}
