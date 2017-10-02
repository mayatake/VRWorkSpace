using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebcamCapture : MonoBehaviour {

	private WebCamTexture webcamtex;

	// Use this for initialization
	void Start () {
		webcamtex = new WebCamTexture ();

		Renderer _renderer = GetComponent<Renderer> ();
		_renderer.material.mainTexture = webcamtex;
		webcamtex.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
