using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour 
{
	private static LevelManager _instance = null;

	public static LevelManager instance 
	{
		get { return _instance; }
	}

	// Use this for initialization
	void Start () 
	{
		if (_instance)
			Destroy(gameObject);
		else
			_instance = this;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GetCommand (string command)
	{
		switch (command)
		{
			case "Shelter":
			Application.LoadLevel("Shelter");
			break;

			case "Streets":
			Application.LoadLevel("Streets");
			break;

			default:
			break;
		}
	}
}
