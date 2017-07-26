using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {

	public UnityEngine.UI.Text iteminfo;
	public RocksClick click;
	public float cost;
	public int tickvalue;
	public int count = 0;
	public string itemname;
	private float basecost;

	void Start(){
		basecost = cost;
	}

	void Update(){
		iteminfo.text = itemname + "\ncost: " + cost + "\ngold: " + tickvalue + "/s";
	}

	public void purchaseditem(){
		if (click.gold >= cost) {
			click.gold -= cost;
			count += 1;
			cost = Mathf.Round (basecost * Mathf.Pow(1.15f, count));
	}
}
}
