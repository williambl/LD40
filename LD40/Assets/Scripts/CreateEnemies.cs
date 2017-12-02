using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemies : MonoBehaviour {

        public GameObject enemy;

        Vector3 pos = new Vector3(8.5f, -2.5f, 0f);
        Quaternion rot = Quaternion.Euler(Vector3.zero);

	// Use this for initialization
	void Start () {
	    InvokeRepeating("Create", 0f, 2f);
	}
	
	void Create () {
	    Instantiate(enemy, pos, rot);	
	}
}
