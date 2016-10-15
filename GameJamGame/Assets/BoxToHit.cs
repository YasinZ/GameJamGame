using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BoxToHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}

    void OnCollisionEnter2D(Collision2D c1)
    {
        Debug.Log("KAPPA");


             SceneManager.LoadScene("new scene");
        }

    //void OnTriggerEnter2D(Collider2D c1) {


    //    for (int i = 0; i < 100000000; i++)
    //    { }


    //    SceneManager.LoadScene("New scene");
    //}

    //ontriggerenter2d
}
