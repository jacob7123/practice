using UnityEngine;
using System.Collections;

public class TestStruct2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SceneInfo2 se1 = new SceneInfo2(50,60);
		SceneInfo2 se2 = se1;

		武器2 戰斧 = new 武器2(100,3,52);
		武器2 戰斧2 = 戰斧;

		se2._height = 9877;
		戰斧2.set攻擊力(6512);

		Debug.Log("Struct:se1:"+se1._height);
		Debug.Log("戰斧:"+戰斧.get攻擊力());

	}

}
