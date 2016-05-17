using UnityEngine;
using System.Collections;

public class CatUI : MonoBehaviour 
{
	public CatStats stats;
	public Transform hungerLevel;
	
	void Start ()
	{
		stats = GetComponent<CatStats>();
	}

	// Update is called once per frame
	void Update () 
	{
		hungerLevel.localScale = new Vector3(stats.GetHunger() / 100.00f, 1);
		hungerLevel.localPosition = new Vector3((stats.GetHunger() / 100.00f - 1) * 0.5f, 0);
		
	}
}
