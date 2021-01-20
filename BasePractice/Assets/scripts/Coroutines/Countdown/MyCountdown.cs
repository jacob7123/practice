using UnityEngine;
using System.Collections;

public class MyCountdown : MonoBehaviour {

	public int maxCount = 10;
	private int count= 0;


	public IEnumerator countdownCoroutine(){
		count= maxCount;

		while(count > 0){
			Debug.Log("Count:"+count);
			count--;
			//暫停一秒
			yield return new WaitForSeconds(1);
		}			
	}
}
