using UnityEngine;
using System.Collections;

public class TestLifeCycle : MonoBehaviour {
	public bool isDestroy;
	void Awake() {
		Debug.Log("Awake");
	}
	void OnEnable() {
		Debug.Log("OnEnable");
	}
	void Start () {
		Debug.Log("Start");
	}
	void Update () {
		Debug.Log("Update");
		if (isDestroy){
			DestroyObject(this);
		}
	}
	void FixedUpdate() {
		Debug.Log("FixedUpdate");
	}
	void OnDisable() {
		Debug.Log("OnDisable");
	}
	void OnDestroy() {
		Debug.Log("OnDestroy");
	}
}
