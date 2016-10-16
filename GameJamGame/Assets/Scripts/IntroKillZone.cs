using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class IntroKillZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Instant reset when object touches wall.
    void OnTriggerEnter2D(Collider2D c1)
    {
        if (c1.gameObject.name.Equals("player"))
        {
            SceneManager.LoadScene("Introlevel");
        }
    }
}
