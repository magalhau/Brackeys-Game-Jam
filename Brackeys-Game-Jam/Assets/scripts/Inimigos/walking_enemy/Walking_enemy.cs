using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking_enemy : MonoBehaviour
{

    [SerializeField] private float speed = 2f;
    Rigidbody2D rb;
    [SerializeField] Transform point1, point2;
    [SerializeField] LayerMask Layer;
    [SerializeField] private bool iscolliding;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

       iscolliding = Physics2D.Linecast(point1.position, point2.position, Layer);

        if (iscolliding)
        {
           transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
           speed *= -1;
        }
    }
}

