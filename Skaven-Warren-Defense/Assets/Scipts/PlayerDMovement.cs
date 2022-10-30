using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDMovement : MonoBehaviour
{
    public CharacterController Player;

    public float speed = 10f;

    private float gravityA = -9.81f;

    private float playerVelocity;
    public Transform groundcheck;
    public float groundD = 0.5f;
    public LayerMask groundMask;
    Vector3 velocity;

    bool isGrounded;
    // player health
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // calling the WASD controlls
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // movement code
        Vector3 Movementpr = transform.right * x + transform.forward * z;

        Player.Move(Movementpr * speed * Time.deltaTime);

        //gravity
        velocity.y += gravityA * Time.deltaTime;

        Player.Move(velocity * Time.deltaTime);

        // checks if player is on the ground
        isGrounded = Physics.CheckSphere(groundcheck.position, groundD, groundMask);


        
    }
}
