﻿using UnityEngine;
using System.Collections;

public class dontdestroy : MonoBehaviour {

	// Use this for initialization
	void Awake () {
       // GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
      //  if (objs.Length > 1)
//Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
		
	}
	
	}
