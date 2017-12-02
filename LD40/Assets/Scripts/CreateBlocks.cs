﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlocks : MonoBehaviour {

        public GameObject[] prefabArray;
        public Vector3 instantiationPosition = new Vector3(0, 5, 0);
        Quaternion instantiationRotation = Quaternion.Euler(Vector3.zero);
        Rigidbody lastCreated;

	// Use this for initialization
	void Start () {
            lastCreated = Instantiate(prefabArray[Random.Range(0, prefabArray.Length)], instantiationPosition, instantiationRotation).GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (lastCreated.IsSleeping())
                lastCreated = Instantiate(prefabArray[Random.Range(0, prefabArray.Length)], instantiationPosition, instantiationRotation).GetComponent<Rigidbody>();
	}
}