using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour {

	private PlayerController playerScript;

	// Use this for initialization
	void Start () {
		playerScript = GameObject.Find("PlayerBody").GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider hit)
	{
		if (hit.gameObject.tag == "Hit" && playerScript.isBigParry)
		{
			destroyObject ();
		}
	}

	void destroyObject()
	{
		//instantiate some particles
		Destroy(gameObject);
	}
}
