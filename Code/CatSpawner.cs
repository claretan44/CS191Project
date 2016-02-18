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
 * Author : Javi Almirante
*/

using UnityEngine;
using System.Collections;

public class CatSpawner : MonoBehaviour {
     public static int score = 0;
     private int spawned = 0;
     public float xLimit = 9.0f;
     public float yLimit = 5.0f;

     private float spawnTimer = 0.0f;
     public float spawnTime = 5.0f;
     public float spawnTimeRangeModifier = 1.5f;

     public Transform minigameCat = null;
     private Transform currentCat = null;

     // Use this for initialization
     void Start () {
          currentCat = Instantiate(minigameCat, new Vector3(Random.Range(-xLimit, xLimit), Random.Range(-yLimit, yLimit)), Quaternion.identity) as Transform;
          spawnTimer = Time.time;
          spawned++;
     }
     
     // Update is called once per frame
     void Update () {
          if (!currentCat || spawnTimer + spawnTime < Time.time)
          {
               if (currentCat) Destroy(currentCat.gameObject);
               currentCat = Instantiate(minigameCat, new Vector3(Random.Range(-xLimit, xLimit), Random.Range(-yLimit, yLimit)), Quaternion.identity) as Transform;
               spawnTimer = Time.time;
               spawned++;
          }
     }

     void OnGUI () {
          GUI.Box(new Rect(0, 0, Screen.width * 0.15f, Screen.height  * 0.075f), "Score: " + score);
          GUI.Box(new Rect(Screen.width * (0.5f - 0.075f), 0, Screen.width * 0.15f, Screen.height  * 0.11f), "TIME\n" + Mathf.FloorToInt(Time.time));
          GUI.Box(new Rect(Screen.width * (1.0f - 0.15f), 0, Screen.width * 0.15f, Screen.height  * 0.075f), "Spawned: " + spawned);
     }
}
