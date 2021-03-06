﻿/**The MIT License (MIT)
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

public class ToolButton : MonoBehaviour 
{
	public bool isActive = false;
	public Transform [] otherButtons;
	public string tool;
	// Use this for initialization
	void Start () 
	{
		if (isActive) SetActive(false);
		else SetActive(true);	
	}

	void OnMouseDown()
	{
		Press();
	}

	void Press()
	{
		if (isActive)
		{
			SetActive(false);
			ShelterPlayer.instance.Equip("None");
		}
		else SetActive(true);
	}

	public void SetActive(bool yes)
	{
		if (yes)
		{
			foreach (Transform t in otherButtons)
			{
				t.GetComponent<ToolButton>().SetActive(false);
				GetComponent<SpriteRenderer>().color = Color.white;
				ShelterPlayer.instance.Equip(tool);
			}
		}
		else
		{
			isActive = false;
			GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f, 1.0f);
		}
	}


}
