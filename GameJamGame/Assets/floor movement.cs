using UnityEngine;
using System.Collections;

public class floormovement : MonoBehaviour {
    float x;
    bool left = false;
    // Use this for initialization
    void Start () {
        float x = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (left)
        {
            x -= .1F;
        }
        else
        {
            x += .1F;
        }
            if (x>=10 || x <= 0)
        {
            left = !left;
        }
        
    }
}
