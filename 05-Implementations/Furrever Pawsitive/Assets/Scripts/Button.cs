using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour 
{
	public string command = "";

	void OnMouseDown()
	{
		Debug.Log("Clicked " + command + "!");
		if (LevelManager.instance) LevelManager.instance.GetCommand(command);
	}
}
