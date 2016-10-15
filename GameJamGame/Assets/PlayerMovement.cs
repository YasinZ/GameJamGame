using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed = 2;
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

        if(Input.GetKeyDown(KeyCode.Space) && Grounded) 
        {
            v2.y = 10;
            rigid.velocity = v2;
        }
	}

    bool Grounded;

    void OnCollisionStay2D(Collision2D collider)
    {
        CheckIfGrounded();
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        Grounded = false;
    }

    private void CheckIfGrounded()
    {
        RaycastHit2D[] hits;

        //We raycast down 1 pixel from this position to check for a collider
        Vector2 positionToCheck = transform.position;
        hits = Physics2D.RaycastAll(positionToCheck, new Vector2(0, -1), 0.01f);

        //if a collider was hit, we are grounded
        if (hits.Length > 0)
        {
            Grounded = true;
        }
    }

}
