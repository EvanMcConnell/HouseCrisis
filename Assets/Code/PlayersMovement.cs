using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayersMovement : MonoBehaviour {

    public float Speed = 10f;
    bool facingRight = true;

    Animator anim;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 700f;

    private Collider2D col;

    // Use this for initialization
    void Start() {
        anim = GetComponent<Animator>();
        col = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        anim.SetBool("grounded", checkGrounded());

        //grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        float Dirx = instantInput(Input.GetAxis("Horizontal"));
        anim.SetFloat("Speed", Mathf.Abs(Dirx));

        //       transform.Translate(Dirx * Time.deltaTime, 0, 0);

        //        if (Dirx > 0 && !facingRight)
        //            flip();
        //        else if (Dirx < 0 && facingRight)
        //            flip();

        //how a tired japub would do it:
        if (Dirx != 0)
        {
            transform.position += new Vector3(Dirx * Time.deltaTime * Speed, 0, 0);
            if (Dirx < 0)
            {
                if (facingRight == true)
                {
                    facingRight = false;
                    flip();
                }
            }
            else
            {
                if(!facingRight)
                {
                    facingRight = true;
                    flip();
                }
            }
        }

    }
    private void Update()
    {
        print(checkGrounded());
        if (checkGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
          //  anim.SetBool("grounded", false);
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
			SoundManagerScript.PlaySound ("jump");

        }
    }
    
    void flip()
    {
  
        transform.Rotate(new Vector3(0,180,0));
    }

    float instantInput(float dir)
    {
        if (dir != 0)
        {
            if (dir < 0) return -1;
            else return 1;
        }
        else return 0;
    }

    bool checkGrounded()
    {

        return (Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround));
    }
}
