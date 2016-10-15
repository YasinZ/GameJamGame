using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public float speed = 10;
    private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {

        rigid = GetComponent<Rigidbody2D>();
	    
	}
	
	// Update is called once per frame
	void Update () {


        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 v3 = new Vector3(inputX * speed, rigid.velocity.y, 0);

        rigid.velocity = v3;

	}
}
