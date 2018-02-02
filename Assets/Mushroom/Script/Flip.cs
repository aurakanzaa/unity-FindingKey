using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour {

    private bool facingRight = true;

    // Update is called once per frame     
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && facingRight)
            Flipp();
        if (Input.GetKeyDown(KeyCode.RightArrow) && !facingRight)
            Flipp();
    }

    void Flipp()
    {
        // Switch the way the player is labelled as facing.         
        facingRight = !facingRight;
        // Multiply the player's x local scale by -1.         
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
