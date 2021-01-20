using UnityEngine;
using System.Collections;
//發送事件
public class SendEvent : MonoBehaviour {
	
	public bool canDestory;
	public int second = 2;
	// 選告一個代理(delegate)類型
	//只要宣告成DestoryAction這個型態的
	//就可以存放 回傳值是void 接收1個int參數
	public  delegate  void DestoryAction(int scend);
	//選告一個event是DestoryAction類型的
	//命名為DestoryActionEvent
	//能注冊的方法必須滿足以下條件
	//1 沒有回傳值
	//2 可接收1個整數類型
	public static event DestoryAction DestoryActionEvent;

	void Update () {		
		if (canDestory){
			//觸發Destory事件
			if (DestoryActionEvent != null){
				DestoryActionEvent(second);
			}

			canDestory = false;
		}
	}
}
