using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }
	}
}
