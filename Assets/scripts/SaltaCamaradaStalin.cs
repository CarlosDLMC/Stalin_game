using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltaCamaradaStalin : MonoBehaviour
{
    public Animator animator;
    public float velocity;
    private Rigidbody2D rb;
    public int jumps = 0;
    public bool is_jumping = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) & jumps < 2)
        {
            rb.velocity = Vector2.up * velocity;
            jumps++;
            is_jumping = true;         


        }
        animator.SetBool("is_jumping", is_jumping);
        
    }
}
