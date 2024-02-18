using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = -9.8f;

    public Vector3 jump;
    public Vector3 moveVelocity;
    public float jumpForce = 15;

    public bool isGrounded;

    private CharacterController _charController;

    void Start()
    {
        _charController = GetComponent<CharacterController>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }


    void Update()
    {
        var hInput = Input.GetAxis("Horizontal") * speed;
        var vInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hInput, 0, vInput);
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);

        if (_charController.isGrounded)
        {
            moveVelocity = transform.forward * speed * vInput;

            if (Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = jumpForce;
                
            }
        }
        //Adding gravity
        moveVelocity.y += gravity * Time.deltaTime;
        _charController.Move(moveVelocity * Time.deltaTime);
    }
}
