﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour {

        public Button startButton;

	// Use this for initialization
	void Start () {
            startButton.onClick.AddListener(StartGame);
	}
	
        void StartGame () {
            SceneManager.LoadScene("main");
        }
}
