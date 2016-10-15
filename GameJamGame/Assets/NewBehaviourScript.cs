using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {


        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 v3 = new Vector3(inputX, inputY, 0);

        transform.Translate(v3 * speed * Time.deltaTime);

	}
}
