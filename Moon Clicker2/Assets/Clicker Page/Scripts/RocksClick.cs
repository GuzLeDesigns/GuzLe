using UnityEngine;
using System.Collections;

public class RocksClick : MonoBehaviour {

	public UnityEngine.UI.Text gpc;
	public UnityEngine.UI.Text goldDisplay;
	public float gold = 0.00f;
	public int goldperclick = 1;

	void Update(){
		goldDisplay.text = " " + gold;
		gpc.text = goldperclick + " g/click";
	}

	public void Clicked(){
		gold = gold + goldperclick;
	}

}
