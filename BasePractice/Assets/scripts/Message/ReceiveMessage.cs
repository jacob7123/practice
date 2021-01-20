using UnityEngine;
using System.Collections;
//接收訊息
public class ReceiveMessage : MonoBehaviour {
	Material material;

	public void Start(){
		Renderer rnd = GetComponent<Renderer>();
		material = rnd.material;
	}
	//改變顏色
	public void changeColor(Color changeColor){		
		material.color = changeColor;
		Debug.Log(transform.name+":Color!!");
	}
}
