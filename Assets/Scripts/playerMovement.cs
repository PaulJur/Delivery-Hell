using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float movementSpeed;

    public Rigidbody2D RB;
    public Animator animator;
    private grabController grab;

    Vector2 movement;

    private void Start()
    {   
        grab = gameObject.GetComponent<grabController>();
        grab.Direction = new Vector2(0,-1);
    }
    void Update()
    {//movement and grabbing by direction.
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if(movement.sqrMagnitude > .01f)
        {
            grab.Direction = movement.normalized;
        }
        //sets which animation is played based on player key input.
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    void FixedUpdate()
    {
        
        RB.MovePosition(RB.position + movement.normalized * movementSpeed * Time.fixedDeltaTime);
    }
}
