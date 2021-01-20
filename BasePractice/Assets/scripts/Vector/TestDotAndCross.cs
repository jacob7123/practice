using UnityEngine;
using System.Collections;

public class TestDotAndCross : MonoBehaviour {
	//參考目標
	public Transform taget;
		void Update () {
		//本地座標轉換成世界座標
		Vector3 forward = transform.
			TransformDirection(Vector3.forward);
		//計算兩個向量的方向
		Vector3 toOther = taget.position - transform.position;

		//計算 Dot 先，注意Dot沒有順序性
		/*float dot = Vector3.Dot(forward,toOther);
		Debug.Log("Dot:"+dot);
		if (dot == 0){
			Debug.Log(taget.name+":平行");
		}else if(dot > 0){
			Debug.Log(taget.name+"前方");
		}else{
			Debug.Log(taget.name+"後方");
		}*/
		//計算 Cross ，注意Cross有順序性，
		//產出垂直於forward與toOther的向量
	Vector3 cross = Vector3.Cross(forward,toOther);
		Debug.Log("cross:"+cross.y);
		if (cross.y == 0){
			Debug.Log(taget.name+":重疊");
		}else if(cross.y > 0){
			Debug.Log(taget.name+"右方");
		}else{
			Debug.Log(taget.name+"左方");
		}

	}
}
