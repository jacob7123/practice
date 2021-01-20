using UnityEngine;
using System.Collections;

public class TestQuaternion : MonoBehaviour {
	//Look對象
	public Transform tagert;

	// Update is called once per frame
	void Update () {
		testLookRotation();
	}
		
	void testLookRotation(){
		//算出方向
		Vector3 direction =  tagert.position - transform.position;
		//算出轉向這個角度所需的四元數Quaternion
		Quaternion lookatQuaternion =  Quaternion.LookRotation(direction);
		//開始平穩的每秒20單位的往lookatQuaternion方向轉
		transform.rotation = Quaternion.RotateTowards(transform.rotation,
			lookatQuaternion,
			150 * Time.deltaTime) ;
	}
}
