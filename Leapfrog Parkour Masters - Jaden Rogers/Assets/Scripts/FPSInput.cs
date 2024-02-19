using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = -9.8f;

    public Vector3 jump;
    public Vector3 moveVelocityOne;
    public Vector3 moveVelocityTwo;

    public float jumpForce = 15;

    public bool isGrounded;

    [SerializeField] private CharacterController _charControllerOne;
    [SerializeField] private CharacterController _charControllerTwo;


    void Start()
    {
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }


    void Update()
    {
        if (_charControllerOne)
        {
            var hInput = Input.GetAxis("Horizontal") * speed;
            var vInput = Input.GetAxis("Vertical") * speed;

            Vector3 movement = new Vector3(hInput, 0, vInput);
            movement.y = gravity;
            movement *= Time.deltaTime;
            movement = transform.TransformDirection(movement);
            _charControllerOne.Move(movement);

            if (_charControllerOne.isGrounded)
            {


                if (Input.GetButtonDown("Jump"))
                {
                    moveVelocityOne.y = jumpForce;

                }
            }
            //Adding gravity
            moveVelocityOne.y += gravity * Time.deltaTime;
            _charControllerOne.Move(moveVelocityOne * Time.deltaTime);
        }
        if (_charControllerTwo)
        {
            var horizontal = 0;
            if (Input.GetKey(KeyCode.J)) horizontal = -1;
            if (Input.GetKey(KeyCode.L)) horizontal += 1;
            var hInput = horizontal * speed;

            var vertical = 0;
            if (Input.GetKey(KeyCode.I)) vertical = 1;
            if (Input.GetKey(KeyCode.K)) vertical -= 1;
            var vInput = vertical * speed;

            Vector3 movement = new Vector3(hInput, 0, vInput);
            movement.y = gravity;
            movement *= Time.deltaTime;
            movement = transform.TransformDirection(movement);
            _charControllerTwo.Move(movement);

            if (_charControllerTwo.isGrounded)
            {


                if (Input.GetButtonDown(KeyCode.P.ToString()))
                {
                    
                    moveVelocityTwo.y = jumpForce;

                }
            }
            //Adding gravity
            moveVelocityTwo.y += gravity * Time.deltaTime;
            _charControllerTwo.Move(moveVelocityTwo * Time.deltaTime);
        }
      
    }


}
