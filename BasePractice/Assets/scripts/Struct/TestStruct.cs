using UnityEngine;
using System.Collections;

public class TestStruct : MonoBehaviour {
	
	void Start () {
		//Struct
		SceneInfo sceneInfo1 = new SceneInfo(100,325);
		SceneInfo sceneInfo2 = sceneInfo1;
		//Class
		武器 狂斧1 = new 武器(127,2,50);
		武器 狂斧2 = 狂斧1;

		Debug.Log("sceneInfo1:"+sceneInfo1._height);
		Debug.Log("狂斧1:"+狂斧1.get攻擊力());

		sceneInfo2._height = 7235;
		狂斧2.set攻擊力(698);

		Debug.Log("sceneInfo1:"+sceneInfo1._height);
		Debug.Log("狂斧1:"+狂斧1.get攻擊力());
	}

}
