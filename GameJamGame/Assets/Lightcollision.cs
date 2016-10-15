using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Lightcollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Sprite Light= new Sprite();
        Debug.Log(Light.associatedAlphaSplitTexture);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D c1)
    {
        SceneManager.LoadScene("New scene");
    }
}
