using UnityEngine;
using System.Collections;

public class CatStats : MonoBehaviour
{
     private int id;
     
     public string name;
     public float hunger;
     public float health;
     public float friendship;

     void Start()
     {
	 }

	 void Update()
	 {
	 	
	 }

	 public void SetName(int _id)
	 {
	      id = _id;
	 }
}
