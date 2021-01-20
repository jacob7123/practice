using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	// 發射速度
	public Vector3 shootSpeed;
	//發射子彈的剛体
	private Rigidbody shootRigibody;

	void Start () {
		//取得剛体
		shootRigibody = GetComponent<Rigidbody>();
	}

	public void shoot(){
		//將靜態設為false，不然無法移動
		shootRigibody.isKinematic = false;
		//發射子彈
		shootRigibody.AddForce(shootSpeed);
	}
}
