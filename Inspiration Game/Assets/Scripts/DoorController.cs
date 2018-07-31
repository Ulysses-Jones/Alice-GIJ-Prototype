using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

	public ZoneController[] zones;
	public float openDelay = 1;       //how long before the door starts to open
	public float doorSpeed = 0.1f;    //how quickly it opens
	public float yDistDown = 1.5f;    //how far down the door moves

	private bool open = false;
	private Vector3 finalPosition;

	// Use this for initialization
	void Start () {
		finalPosition = new Vector3 (transform.position.x,transform.position.y - yDistDown,transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

		bool incompleteZoneFound = false;

		if (!open) {
			for (int i = 0; i < zones.Length; i++) {
				if (zones [i].zoneComplete == false) {
					incompleteZoneFound = true;
				}
			}

			if (incompleteZoneFound == false) {   //implies all zones are complete
				Invoke ("openDoor", openDelay);
			}
		}
		else
		{
			transform.position = Vector3.Lerp (transform.position, finalPosition, doorSpeed);
		}
	}

	void openDoor()
	{
		open = true;
	}
}
