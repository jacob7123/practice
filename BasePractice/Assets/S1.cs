using UnityEngine;
using System.Collections;

public class S1 : MonoBehaviour {
	public Transform tt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 forward = transform.TransformDirection(Vector3.forward);
		Vector3 toOther = tt.position - transform.position;
		float vv = Vector3.Dot(forward, toOther.normalized);

		Vector3 cross = Vector3.Cross(forward,toOther.normalized);

		Debug.Log("forward:"+forward);
		Debug.Log("toOther:"+toOther.normalized);
		Debug.Log("Dot:"+vv);
		Debug.Log("Cross:"+cross.y);

		if (Vector3.Dot(forward, toOther) < 0)
			print("The other transform is behind me!");

		/*Vector3 forward = transform.TransformDirection(Vector3.forward);
		Vector3 distance =  tt.position - transform.position;
		Vector3 v3 = Vector3.Cross(forward,distance.normalized);
		Debug.Log("normalized:"+distance.normalized);
		Debug.Log("Vector3:"+v3);
		Debug.Log("forward:"+forward);*/
		/*	Vector3 v1 = new Vector3(1,1,1);
		Vector3 v2 = new Vector3(1,1,1);
		Vector3 dist =  v2 - v1;
		float dot = Vector3.Dot(v1,dist);
		Debug.Log("distance:"+distance);
		Debug.Log("Dot:"+dot);*/
	}
}
