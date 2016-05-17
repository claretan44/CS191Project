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
 * Author : Javi Almirante, Clare Tan, Arel Latoga
*/

using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public bool resetAllData;


	// Use this for initialization
	void Start () {
	     if (resetAllData) KillCats();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
/*
	void OnGUI ()
	{
		if (GUI.Button(new Rect(Screen.width * (0.5f - 0.075f), Screen.height * (0.5f - 0.055f), Screen.width * 0.15f, Screen.height  * 0.11f), "PLAY")) Application.LoadLevel(1) ;
		if (GUI.Button(new Rect(Screen.width * (0.5f - 0.075f) + 100, Screen.height * (0.5f - 0.055f) + 100, Screen.width * 0.15f, Screen.height  * 0.11f), "shelter")) Application.LoadLevel(2) ;
        if (GUI.Button(new Rect(Screen.width * (0.5f - 0.075f), Screen.height * (0.5f - 0.055f) + Screen.height  * 0.11f, Screen.width * 0.15f, Screen.height  * 0.11f), "EXIT")) Application.Quit() ;
	}
*/
	void KillCats()
	{
	     PlayerPrefs.DeleteAll();
	}
}
