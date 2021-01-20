using UnityEngine;
using System.Collections;
using com.gmail.howard;
public class TestNamespace : MonoBehaviour {

	void Start () {
		com.gmail.howard.Car car1 = 
			new com.gmail.howard.Car();
		
		com.gmail.ken.Car car2 = 
			new com.gmail.ken.Car();
		Car car3 = new Car();

		Debug.Log(car1.showOwner());
		Debug.Log(car2.showOwner());
		Debug.Log(car3.showOwner());
	}

}
