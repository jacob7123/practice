using UnityEngine;
using System.Collections;

public class TestInvoke : MonoBehaviour {

	public bool callDelayInvoke = false;
	public bool callInvokeRepeating = false;

	//呼叫delayMethod的時間點
	float callInvokeTime = 0;
	//倒數計時起始數值
	public int startCount = 5;
	//倒數計時計算用
	int count = 0;

	void Update () {
		if (callDelayInvoke){
			callInvokeTime = Time.time;
			callDelayInvoke = false;
			//延遲2秒後呼叫delayMethod
			Invoke("delayMethod",2);
		}

		if (callInvokeRepeating){
			callInvokeRepeating = false;
			count = startCount;
			//第一次呼叫延遲0秒
			//每1秒呼叫一次
			InvokeRepeating("countdown",0,1);
		}
	}

	//2秒後呼叫
	void delayMethod(){		
		Debug.Log("delay:"+(Time.time -callInvokeTime) );
	}
	//倒數計時
	void countdown(){		
		Debug.Log("countdown:"+(count));
		count--;
		if (count == 0){
			//取消呼叫InvokeRepeating方法
			CancelInvoke("countdown");
		}
	}

}
