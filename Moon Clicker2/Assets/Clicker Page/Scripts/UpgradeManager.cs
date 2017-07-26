using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour {

	public RocksClick click;
	public UnityEngine.UI.Text iteminfo;
	public float cost;
	public int count = 0;
	public int clickpower;
	public string itemname;
	private float basecost;

	void Start(){
		basecost = cost;
	}

	void Update(){
		iteminfo.text = itemname + "\nCost: " + cost + "\nPower: +" + clickpower;
	}

	public void purchasedupgrade(){
		if (click.gold >= cost) {
			click.gold -= cost;
			count += 1;
			click.goldperclick += clickpower;
			cost = Mathf.Round (basecost * Mathf.Pow (1.15f, count));
		}
	}
}
