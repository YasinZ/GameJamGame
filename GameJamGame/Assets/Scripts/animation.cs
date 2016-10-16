using UnityEngine;
using System.Collections;

public class animation : MonoBehaviour
{
    Animator animator;

    const int STATE_IDLE = 0;
    const int STATE_WALK = 1;
    int _currentAnimationState = STATE_IDLE;
    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //if (_currentAnimationState == STATE_IDLE)
        //{
        animator.SetInteger("state", STATE_WALK);
        changeState(STATE_WALK);
        //}
 
    }
    void changeState(int state)
    {

        if (_currentAnimationState == state)
            return;

        switch (state)
        {
            case STATE_WALK:
                animator.SetInteger("state", STATE_WALK);
                Debug.Log("hi");
                break;

            case STATE_IDLE:
                animator.SetInteger("state", STATE_IDLE);
                break;
        }

        _currentAnimationState = state;
    }
}
