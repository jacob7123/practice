using UnityEngine;
using System.Collections;

public class TestBasex : MonoBehaviour {
	
	void Start () {
		武器2 王之劍 = new  武器2(754,20,90);

		//Debug.Log("攻擊力:"+王之劍.get攻擊力());
		Debug.Log("等級限制:"+王之劍.等級限制);
	}



}
