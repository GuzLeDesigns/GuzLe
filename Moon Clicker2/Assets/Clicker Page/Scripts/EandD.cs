using UnityEngine;
using System.Collections;

public class EandD : MonoBehaviour 
{   public GameObject Enable_Disable ;
	
	public void Enable()
	{
		Enable_Disable.SetActive(true);

	}

	public void Disable()
	{
		Enable_Disable.SetActive (false);

	}
}
