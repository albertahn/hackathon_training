using UnityEngine;
using System.Collections;

public class Pika_animate : MonoBehaviour {


	private bool toggleHit = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (!toggleHit) {
			
			this.transform.Rotate (-1, 0, 0);

		} else {//
			
			this.transform.Rotate (1, 0, 0);

		}



	}
}
