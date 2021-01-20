using UnityEngine;
using System.Collections;

public class TestCoroutines : MonoBehaviour {
	//記錄呼叫Coroutine的時間
	private float  callCoroutinesTime = 0;
	void Start(){
		//啟動Coroutine
		StartCoroutine( CoroutinesFunction());
	}

	//Coroutine函數
	public IEnumerator CoroutinesFunction(){
		//第一次呼叫Coroutine的時間
		callCoroutinesTime = Time.time;
		Debug.Log("callCoroutinesTime 1");
		//暫停3秒
		yield return new WaitForSeconds(3);
		//算出時間差
		float  lastTime = Time.time - callCoroutinesTime;
		Debug.Log("callCoroutinesTime 2: "+lastTime);

	}

}
