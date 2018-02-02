using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 10;
    private Rigidbody2D rigidBody2D;
    private Animator myAnimator;
    [SerializeField]
    private Transform[] groundPoints;
    [SerializeField]
    private float groundRadius;

    /*public Transform corner_max;
    public Transform corner_min;
    private float x_min;
    private float y_min;
    private float x_max;
    private float y_max;*/

    [SerializeField]
    private LayerMask whatIsGround;

    private bool isGrounded;

    private bool jump;

    [SerializeField]
    private float jumpForce;
    
	void Awake()
    {
	    rigidBody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        /*x_max = corner_max.position.x;
        x_min = corner_min.position.x;
        y_max = corner_max.position.y;
        y_min = corner_min.position.y;*/
    }
    void FixedUpdate()
    {
        isGrounded = IsGrounded();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
        float xMove = Input.GetAxis("Horizontal");
        Movement(xMove);

        resetValues();
        //KeepWithinMinMaxRectangle();
    }
    private void Movement(float xMove)
    {
		if (isGrounded && jump)
        {
            isGrounded = false;
            rigidBody2D.AddForce(new Vector2(0, jumpForce));
        }
        rigidBody2D.velocity = new Vector2(xMove * speed, rigidBody2D.velocity.y);
        myAnimator.SetFloat("speed", Mathf.Abs(xMove));
    }
	 private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }
	private void resetValues()
    {
        jump = false;
    }

	private bool IsGrounded()
    {
        if (rigidBody2D.velocity.y <= 0)
        {
            foreach (Transform point in groundPoints)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);

                for (int i = 0; i < colliders.Length; i++)
                {
                    if (colliders[i].gameObject != gameObject)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    /*
    private void KeepWithinMinMaxRectangle()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        float clampedX = Mathf.Clamp(x, x_min, x_max);
        float clampedY = Mathf.Clamp(y, y_min, y_max);
        transform.position = new Vector3(clampedX, clampedY, z);
    }

    void OnDrawGizmos()
    {
        Vector3 top_right = Vector3.zero;
        Vector3 bottom_right = Vector3.zero;
        Vector3 bottom_left = Vector3.zero;
        Vector3 top_left = Vector3.zero;

        if (corner_max && corner_min)
        {
            top_right = corner_max.position;
            bottom_left = corner_min.position;
            bottom_right = top_right;
            bottom_right.y = bottom_left.y;
            top_left = top_right; top_left.x = bottom_left.x;
        }         
        //Set the following gizmo colors to YELLOW         
        Gizmos.color = Color.yellow;
        //Draw 4 lines making a rectangle        
        Gizmos.DrawLine(top_right, bottom_right);
        Gizmos.DrawLine(bottom_right, bottom_left);
        Gizmos.DrawLine(bottom_left, top_left);
        Gizmos.DrawLine(top_left, top_right);
    }*/ 
   }
