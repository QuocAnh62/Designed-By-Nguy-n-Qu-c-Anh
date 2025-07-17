using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : PlayerLookRotation
{
    [SerializeField] private FixedJoystick joyStick;

    private Rigidbody rb;
    private Animator anim;

    private float speedPlayer = 7f;
  

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    protected void FixedUpdate()
    {     
        Move();
    }

    private void Move() // calculte move and rotation character
    {
        rb.velocity =
            new Vector3(joyStick.Horizontal * speedPlayer, rb.velocity.y, joyStick.Vertical * speedPlayer);
        if (joyStick.Horizontal >= 0.2f || joyStick.Horizontal <= -0.2f || joyStick.Vertical >= 0.2f || joyStick.Vertical <= -0.2f)
        {
            LookRotation(joyStick);
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }

    } 

}
