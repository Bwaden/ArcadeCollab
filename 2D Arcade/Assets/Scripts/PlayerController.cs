using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Animator animator;

  

    Vector2 movement;


    // Start is called before the first frame update

    // Update is called once per frame

    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");


        animator.SetFloat("Horizontal", movement.x);

        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}