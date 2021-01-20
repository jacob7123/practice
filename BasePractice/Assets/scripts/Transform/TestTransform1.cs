using UnityEngine;
using System.Collections;

public class TestTransform1 : MonoBehaviour {
	public Transform target;
	//宣告依Y軸旋轉270度
	Vector3 euler = new Vector3(0,270,0);
	//往前移動5個單位
	Vector3 move = Vector3.forward * 5;

	void testPosition(){
		//使用transform.positio移動
		transform.position=move ; 	
	}

	void testTranslate(){
		//使用transform.Translate每秒移動5格
		transform.Translate(move * Time.deltaTime);
	}

	void testRotation(){
		//rotation 依Y軸旋轉270度 是使用Quaternion設定
		//Quaternion不直覺通常會先轉成向量再轉回Quaternion
		//transform.rotation = Quaternion.Euler(euler);
		//每秒轉270度不停的旋轉
		transform.Rotate(euler * Time.deltaTime);
	}

	void testEulerAngles(){
		//使用eulerAngles設定旋轉角度
		//可直接使用向量旋轉
		transform.eulerAngles = euler;
	}

	void testTransformDirection(){
		//沒有把 local space 轉換到 world space.
		transform.position+=move * Time.deltaTime;
		//有把 local space 轉換到 world space.
		/*transform.position+=transform.TransformDirection(move) 
			* Time.deltaTime;*/
	}

	void testLookAt(){
		transform.LookAt(target.position);
	}



	void Update () {
		testPosition();
		//testTranslate();
		//testTransformDirection();
		//testRotation();
		//testEulerAngles();
		//testLookAt();
	}

}
