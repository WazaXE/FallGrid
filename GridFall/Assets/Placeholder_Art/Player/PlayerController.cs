using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR;
using Debug = UnityEngine.Debug;
using UnityEngine.InputSystem;



public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;
    public LayerMask whatStopsMovement;

    public Animator anim;
    public float jumpForce;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    private PlayerInput playerInput;
    public InputAction playerControl;

    private void OnEnable()
    {
        playerControl.Enable();

    }

    private void OnDisable()
    {
        playerControl.Disable();
    }
 
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;     
    }
 
    // Update is called once per frame
    void Update()
    {
        
        

      //grid based movement
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            //if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
                //add else before IF statment and you remove diagnoal movemnt;
            } //if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
                    
            }
            //animation with a yes or no;
            anim.SetBool("move", false);
        }else
        {
            anim.SetBool("move", true);
        }


        

    }
    


}

