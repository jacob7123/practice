using UnityEngine;
using System.Collections;

public class 武器2 {
	private float _攻擊力;
	private float _磨損程度;
	private int _等級限制;

	public 武器2(){
	}
	public 武器2(float 攻擊力,float 磨損程度,int 等級限制){
		_攻擊力 = 攻擊力;
		_磨損程度 = 磨損程度;
		_等級限制 = 等級限制;
	}


	public float get攻擊力(){

		return _攻擊力;
	}

	public void set攻擊力(float 攻擊力){

		if (攻擊力 < 0){
			Debug.Log("攻擊力不可小於零!");
			攻擊力 = 0;
		}
		_攻擊力 = 攻擊力;
	}

	public int 等級限制{

		get{
			return _等級限制;
		}

		set{
			_等級限制 = value;
		}
	}

}
