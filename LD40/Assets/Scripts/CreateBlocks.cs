using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlocks : MonoBehaviour {

        public GameObject[] prefabArray;
        Rigidbody lastCreated;

	// Use this for initialization
	void Start () {
            lastCreated = Instantiate(prefabArray[Random.Range(0,prefabArray.Length)]).GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (lastCreated.IsSleeping())
                lastCreated = Instantiate(prefabArray[Random.Range(0,prefabArray.Length)]).GetComponent<Rigidbody>();
	}
}
