/**The MIT License (MIT)
 *
 * Copyright (c) 2016 Almirante, Latoga, Tan
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

/*
 This is a course requirement for CS 192 Software Engineering II under the supervision of 
 Asst. Prof. Ma. Rowena C. Solamo of the Department of Computer Science,
 College of Engineering, University of the Philippines, Diliman for the AY 2014-2015
*/

/**
 * Author : Javi Almirante, Clare Tan
*/
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
//                GameObject sp = GameObject.Find("Spawner");
//                sp.GetComponent<CatSpawner>().SaveData();
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
