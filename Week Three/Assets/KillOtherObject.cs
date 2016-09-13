using UnityEngine;
using System.Collections;

public class KillOtherObject : MonoBehaviour {
	int lives = 30;

	// Use this for initialization
	void OnTriggerExit( otherObj ) {
		otherObj.transform.position =KillOtherObject.position + Vector3.up * 40;
		otherObj.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero
		//Destroy otherObj;
		Debug.Log ("Things moving out of the box.");
	}
