using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlocks : MonoBehaviour {

        public GameObject[] prefabArray;

	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
	    GameObject block = Instantiate(prefabArray[0]);
	}
}
