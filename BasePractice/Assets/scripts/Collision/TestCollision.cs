using UnityEngine;
using System.Collections;

public class TestCollision : MonoBehaviour {
	
	void OnCollisionEnter(Collision collision) {
		//進入Collision
		Debug.Log("OnCollisionEnter " + collision.transform.name);
	}
	void OnCollisionExit(Collision collisionInfo) {
		//離開Collision
		Debug.Log("OnCollisionExit " + collisionInfo.transform.name);
	}

	void OnTriggerEnter(Collider other) {
		//進入Trigger
		Debug.Log("OnTriggerEnter: "+other.name);
		Destroy(other.gameObject);
	}
	void OnTriggerExit(Collider other) {
		//離開Trigger
		Debug.Log("OnTriggerExit: "+other.name);
	}
		
}
