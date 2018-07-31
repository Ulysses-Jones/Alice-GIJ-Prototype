using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider hit)
	{
		if (hit.gameObject.tag == "Hit")
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
