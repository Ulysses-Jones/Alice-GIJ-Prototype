using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelPortal : MonoBehaviour {

    SceneManagementScript sceneScript;

	// Use this for initialization
	void Start () {

        sceneScript = GameObject.Find("gameManager").GetComponent<SceneManagementScript>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
        }
    }
}
