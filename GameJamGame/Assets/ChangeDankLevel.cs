﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeDankLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	// Instant reset when object touches wall.
	void OnCollisionEnter2D(Collision2D c1)
	{
		SceneManager.LoadScene("Much meme such dank");
	}
	
}