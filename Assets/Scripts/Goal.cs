﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
	static public bool goalNet= false;

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Projectile"){
			Goal.goalNet = true;
			Material mat = GetComponent<Renderer>().material;
			Color c = mat.color;
			c.a =1;
			mat.color=c;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
