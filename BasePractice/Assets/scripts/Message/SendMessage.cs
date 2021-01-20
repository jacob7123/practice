using UnityEngine;
using System.Collections;
//發送訊息
public class SendMessage : MonoBehaviour {
	public bool sendMessage;
	public bool sendMessageUpwards;
	public bool broadcastMessage;


	void Update () {
		//呼叫本身的changeColor方法
		if (sendMessage){
			SendMessage("changeColor",Color.cyan);
			sendMessage = false;
		}
		//呼叫本身與上層的changeColor方法
		if (sendMessageUpwards){
			SendMessageUpwards("changeColor",Color.gray);
			sendMessageUpwards = false;
		}
		//呼叫本身與子層的changeColor方法
		if (broadcastMessage){
			BroadcastMessage("changeColor",Color.black);
			broadcastMessage = false;
		}	
	}
}
