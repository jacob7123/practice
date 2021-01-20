using UnityEngine;
using System.Collections;
//接收事件
public class ReceiveEvent : MonoBehaviour {
	
	void OnEnable() {
		//注冊DestoryActionEvent事件
		SendEvent.DestoryActionEvent += clearGameObject;
	}
	void OnDisable(){
		//取消DestoryActionEvent事件
		SendEvent.DestoryActionEvent -= clearGameObject;
	}
		
	//移除GameObject物件
	public void clearGameObject(int second){
		Debug.Log("Destroy:"+name);
		Destroy(gameObject,second);
	}

}
