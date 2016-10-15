using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Lightcollision : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Sprite Light = new Sprite();
        Debug.Log(Light.associatedAlphaSplitTexture);
    }

    // Update is called once per frame
    void Update()
    {
       // GetComponent<Renderer>().material.color -= new Color(0, 0, 0, .01f);
    }
    void OnTriggerEnter2D(Collider2D c1)
    {
        //GetComponent<Renderer>().material.color += new Color(0, 0, 0, 1f);
    }
}
    
