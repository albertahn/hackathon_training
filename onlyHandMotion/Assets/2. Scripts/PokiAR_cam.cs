using UnityEngine;
using System.Collections;

public class PokiAR_cam : MonoBehaviour {

	// Use this for initialization

	public WebCamTexture mCamera = null;
	public GameObject backgroundPlane;


	void Start () {

		backgroundPlane = GameObject.Find ("backgroundPlane");

		mCamera = new WebCamTexture ();

		backgroundPlane.GetComponent<Renderer> ().material.mainTexture = mCamera;

		mCamera.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}//update


}//class
