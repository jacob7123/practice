using UnityEngine;
using System.Collections;
public class TestComponent : MonoBehaviour {
	//移動速度
	public float speed = 100;
	// 取得Cub2剛体
	private Rigidbody rigidbody;
	//取得發射物件
	// 注意這個類別要先建立不然會出錯
	private Shoot shootObj;
	void Start () {
		// 取得Cub2 Rigidbody 元件
		rigidbody = GetComponent<Rigidbody>();
		// 取得子物體的Shoot元件
		shootObj = 
			GetComponentInChildren<Shoot>();
	}	
	// 因為是物理部份所以使用FixedUpdate
	void FixedUpdate () {
		//左右移動
		float x =  Input.GetAxis("Horizontal");
		float y =   Input.GetAxis("Vertical");
		//按下滑鼠左鍵
		if (Input.GetMouseButton(0)){
			shootObj.shoot();
		}
		//設定力的方向
		Vector3 force = new Vector3(x * speed
										,0,y* speed);
		//給剛体一個力
		rigidbody.AddForce(force);
	}
}