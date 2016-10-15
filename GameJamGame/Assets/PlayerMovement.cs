using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed = 10;
    private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {

        rigid = GetComponent<Rigidbody2D>();
	    
	}
	
	// Update is called once per frame
	void Update () {

        float inputX = Input.GetAxis("Horizontal");

        Vector2 v2 = new Vector2(inputX * speed, rigid.velocity.y);

        rigid.velocity = v2;

        if(Input.GetKeyDown(KeyCode.Space) ) 
        {
            v2.y = 5;
            rigid.velocity = v2;
            
        }


	}
}
