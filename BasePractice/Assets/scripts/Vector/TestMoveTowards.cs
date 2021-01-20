using UnityEngine;
using System.Collections;

public class TestMoveTowards : MonoBehaviour {
	//移動到哪個位置
	public Vector3 tagerPoint ;
	//移動的速度
	public int speed = 3;

	void Update () {
		//目前的座標點
		Vector3 currentPoint = transform.position;
		//每次移動的距離
		float maxDistanceDelta = Time.deltaTime * speed;
		//最後會回傳tagerPoint不會超過tagerPoint
		transform.position = Vector3.MoveTowards(currentPoint
			,tagerPoint,
			maxDistanceDelta);
	}
}
