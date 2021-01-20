using UnityEngine;
using System.Collections;

public class TestScreenToRay : MonoBehaviour {

	void Update () {
		//取得滑鼠的座標點
		Vector3 point = 	  Input.mousePosition;
		//將螢幕座標點轉換成射線
		Ray ray =  Camera.main.
				ScreenPointToRay(point);
		//場景編輯器畫出紅色射線
		//長度1000方向由Ray來
		Debug.DrawRay(ray.origin,
					ray.direction * 1000,
			Color.red);
	}
}
