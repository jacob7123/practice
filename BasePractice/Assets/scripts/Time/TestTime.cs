using UnityEngine;
using System.Collections;

public class TestTime : MonoBehaviour {
	//給於Time.timeScale 的數值
	public float timeScale = 0;
	//是否可設定Time.timeScale 
	public bool changeScale = false;

	void Awake(){
		//要先去Unoty3d設定給定FPS才有效果
		Application.targetFrameRate = 30;
	}
	void Update () {
		//如果可以改變Scale
		if (changeScale){
			Time.timeScale = timeScale;
			changeScale = false;
		}
		Debug.Log("Time:"+Time.time);
		Debug.Log("RealtimeSinceStartup:"+
						Time.realtimeSinceStartup);
		Debug.Log("Update DeltaTime:"+Time.deltaTime);
	}

	void FixedUpdate(){
		Debug.Log("FixedUpdate DeltaTime:"+Time.deltaTime);
	}
}
