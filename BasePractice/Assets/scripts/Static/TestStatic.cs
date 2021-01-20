using UnityEngine;
using System.Collections;

public class TestStatic : MonoBehaviour {

	public static int sceneLevel = 1;
	public int attack = 0;

	void Start () {
		TestStatic.sceneLevel = 2;
		TestStatic testStatic = new TestStatic();
		testStatic.attack = 20;
		t1();
	}

	public static void t1(){
		
	}
		
}
