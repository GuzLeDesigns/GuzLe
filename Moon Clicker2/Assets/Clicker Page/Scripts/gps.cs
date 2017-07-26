using UnityEngine;
using System.Collections;

public class gps : MonoBehaviour {

	public UnityEngine.UI.Text gpsDisplay;
	public RocksClick click;
	public ItemManager[] items;

	void Start (){
		StartCoroutine (AutoTick ());
	
	}

	void Update(){
		gpsDisplay.text = GetGoldPerSec () + " g/sec";
	}

	public int GetGoldPerSec(){
		int tick = 0;
		foreach (ItemManager item in items) {
			tick += item.count * item.tickvalue;
		}
			return tick;
	}

	public void AutoGoldPerSec(){
		click.gold += GetGoldPerSec ();
	}

	IEnumerator AutoTick(){
		while (true) {
			AutoGoldPerSec ();
			yield return new WaitForSeconds (1);
		}
	}
}
