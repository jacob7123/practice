using UnityEngine;
using System.Collections;

public class TestCoroutine2 : MonoBehaviour {
	int value = 0;
	// Use this for initialization
	void Start () {		

	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.Log("Update deltaTime:"+Time.deltaTime);

	}

	public IEnumerator test(){
		while(true){
			Debug.Log("test value:"+value);
			value = 20;
			yield return new WaitForEndOfFrame();
		
		}
	}

	public IEnumerator test2(){
		while(true){
			Debug.Log("test2 value:"+value);
			value = 30;
			yield return null;
		
		}
	}

}
