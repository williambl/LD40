using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: MonoBehaviour {

        CharacterController control;
        public Vector3 speed;

	// Use this for initialization
	void Start () {
	    control = GetComponent<CharacterController>();	
	}
	
	// Update is called once per frame
	void Update () {
            control.SimpleMove(speed);
	}
}
