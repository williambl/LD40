using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: MonoBehaviour {

        Rigidbody rigid;
        public Vector3 speed;

	// Use this for initialization
	void Start () {
	    rigid = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {
            rigid.AddForce(speed);
            if (-rigid.velocity.x < 0.1)
                speed = new Vector3(speed.x-0.1f, speed.y, speed.z);
	}
}
