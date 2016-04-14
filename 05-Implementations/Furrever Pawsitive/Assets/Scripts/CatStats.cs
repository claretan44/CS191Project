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

public class CatStats : MonoBehaviour
{
     private int id;
     
     public string name;
     public float hunger;
     public float health;
     public float friendship;

     public float hungerIncrement = 5;
     public float hungerInterval = 10.0f;
     public float timeSinceLastHunger;

     void Awake()
     {
     	hunger = 75;
     	friendship = 0;
     }

     void Start()
     {
     	timeSinceLastHunger = Time.time;
	 }

	 void Update()
	 {
	 	if (timeSinceLastHunger + hungerInterval <= Time.time)
	 	{
	 		// Update Hunger.
	 		GetHungry(hungerIncrement);
	 		timeSinceLastHunger = Time.time;
	 	}
	 }

	 public float GetHunger ()
	 {
	 	return hunger;
	 }


	 void GetHungry (float inc)
	 {
	 	hunger -= inc;
	 	if (hunger <= 0) Destroy(this.gameObject);
	 }

	 void Feed (float amount)
	 {
	 	hunger += amount;
	 	if (hunger >= 100) hunger = 100;
	 }

	 public void SetName(int _id)
	 {
	      id = _id;
	 }

	 void OnMouseDown ()
	{
		Feed(10);
	}

}
