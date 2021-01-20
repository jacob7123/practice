using UnityEngine;
using System.Collections;
public class TestLerap : MonoBehaviour {
	float lerpNumber =0;
	//取得材質
	Material materialComp = null;
	//設定旋轉腳度
	Quaternion euler ;
	void Start(){
		//取得material材質
		materialComp = GetComponent<Renderer>().material;
		euler = Quaternion.Euler(new Vector3(0,180,0));
	}
	void Update () {
		//觀察數值變換
		lerpNumber = Mathf.Lerp(lerpNumber,100,0.5f);	
		Debug.Log(lerpNumber);
		//顏色差值
	materialComp.color = Color.Lerp(materialComp.color,
															Color.blue,
															Time.deltaTime);
		//移動差值
		transform.position = Vector3.Lerp(transform.position,
															new Vector3(20,0,0),
															Time.deltaTime );		
		//旋轉差值
		transform.rotation = Quaternion.Lerp(transform.rotation,
																euler,
																Time.deltaTime * 2);
	}
}
