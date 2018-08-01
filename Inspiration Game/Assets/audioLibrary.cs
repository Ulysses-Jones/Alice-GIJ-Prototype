using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioLibrary : MonoBehaviour {

    public AudioClip pDeath, pMove, pAttackWide, pAttackPrecise;
    public AudioClip eDeath, eMove, eBullet, eLazer, eLazerBuildUp;
    public AudioClip doorOpen, teleport;


    public static audioLibrary instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
            Destroy(gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
