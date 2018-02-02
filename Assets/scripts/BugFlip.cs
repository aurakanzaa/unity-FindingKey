using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugFlip : MonoBehaviour {

    private bool facingRight = true;

    //update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && facingRight) Flip();
        if (Input.GetKeyDown(KeyCode.RightArrow) && !facingRight) Flip();
    }

    void Flip()
    {
        //switch the way the player is labelled as facing
        facingRight = !facingRight;
        //multiply the player's x local scale by -1
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
