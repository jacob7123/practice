using UnityEngine;
using System.Collections;
public class TestRaycat : MonoBehaviour {
	//設定距離為100
	public float distnce = 100;
	//因為要改變顏色所以要取的Renderer
	private Renderer hitRenderer;
	void Update () {
		//指定方向為前方，因為會旋轉所以必須轉換座標
		Vector3 forward = transform.
			TransformDirection(Vector3.forward);
		//建立一個射線
		//public Ray(Vector3 origin, Vector3 direction);
		Ray ray = new Ray(transform.position,
			forward );
		//畫出射線除錯用，再遊戲內是看不到的
		Debug.DrawRay(ray.origin,ray.direction * distnce,Color.blue);
	    //取得碰撞
		RaycastHit hit;
		//使用Layer name取得layerMask
		int layerMask = LayerMask.GetMask("NPC_Layer");
		//判斷是否有碰撞到物體加入了layerMask
		if (Physics.Raycast(ray,out hit,distnce,layerMask)){
		//沒有layerMask
		//if (Physics.Raycast(ray,out hit,distnce)){
			//改變顏色為藍色
			hitRenderer = hit.collider.GetComponent<Renderer>();
			hitRenderer.material.color = Color.blue;
		}else if(hitRenderer != null){
			//沒有碰撞改變為紅色
			hitRenderer.material.color = Color.red;
			hitRenderer = null;
		}
	}
}
