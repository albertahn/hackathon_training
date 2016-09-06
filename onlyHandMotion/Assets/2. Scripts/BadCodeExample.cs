using UnityEngine;
using System.Collections;

public class BadCodeExample : MonoBehaviour {

	// Use this for initialization

	public GameObject a,b,c,d, player;
	Vector3 spawnPos;

	void Start () {

//1. Instantiating too many objects within game
		spawnPos = new Vector3(0,0,0);

		a = (GameObject)Instantiate(player,spawnPos,Quaternion.identity);

		b = (GameObject)Instantiate(player,spawnPos,Quaternion.identity);

		c = (GameObject)Instantiate(player,spawnPos,Quaternion.identity);



		d = (GameObject)Instantiate(player,spawnPos,Quaternion.identity);

		GameObject.Destroy (a);
		GameObject.Destroy (b);
		GameObject.Destroy (c);
		GameObject.Destroy (d);

		//=> after loading the objects, just change the visibility through:   renderer.enabled = true;
	
	}
	
//2. leaving empty functions : delete the empty method if there is nothing inside.
	void Load(){


	}
//3. Using Update for everything   : called each frame costing you CPU cycles 
	void Update () {  
		StartCoroutine (badIEnum());

	
	}


//4. too many coroutines 
	//when to use : has two or more pieces of code and sequential series of steps which involve a lot of waiting. etc : server post or get calls 

	private IEnumerator badIEnum(){

		yield return  null;
	
	}
}
