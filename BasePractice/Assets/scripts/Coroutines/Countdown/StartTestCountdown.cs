using UnityEngine;
using System.Collections;

public class StartTestCountdown : MonoBehaviour {
	public bool  countdown;
	MyCountdown myCountdown;
	void Start(){
		//取得MyCountdown物件
		myCountdown = GetComponent<MyCountdown>();
	}
	// Update is called once per frame
	void Update () {

		if ( countdown){
			// 啟動倒數計Coroutine時協同
			StartCoroutine(myCountdown.countdownCoroutine());
			countdown = false;
		}
	}
}