using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelPortal : MonoBehaviour {

    SceneManagementScript sceneScript;

    //audio references
    audioLibrary audioLib;
    AudioSource myAudSource;

    bool changing = false;

	// Use this for initialization
	void Start () {

        sceneScript = GameObject.Find("gameManager").GetComponent<SceneManagementScript>();

        audioLib = GameObject.Find("audioLibrary").GetComponent<audioLibrary>();
        myAudSource = gameObject.GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && changing == false)
        {
            changing = true;
            myAudSource.Stop();
            myAudSource.clip = audioLib.teleport;
            myAudSource.Play();

            sceneScript.NextLevelTransition();
        }
    }
}
