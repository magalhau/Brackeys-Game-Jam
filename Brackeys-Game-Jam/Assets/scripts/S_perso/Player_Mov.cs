using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Mov : MonoBehaviour
{
    private float horizontalInput;
    private Rigidbody2D rb;

    public int velocity;
    public float jumpForce;

    [SerializeField] private Transform pedoperso;
    [SerializeField]private LayerMask groundLayer;

    private bool grounded;

    private Animator Animator;
    private int movendoHash = Animator.StringToHash("movendo");
    private int saltandoHash = Animator.StringToHash("saltando");

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();    
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");
            
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            Animator.SetTrigger("saltando");    
        }
       

        grounded = Physics2D.OverlapCircle(pedoperso.position, 0.1f, groundLayer);

        Animator.SetBool(movendoHash, horizontalInput != 0);
        Animator.SetBool(saltandoHash, !grounded);

        if (horizontalInput > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
        }


    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * velocity, rb.velocity.y);
    }
}
