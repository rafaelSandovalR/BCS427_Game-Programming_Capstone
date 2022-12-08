using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {


    public float moveSpeed = 2.0f;
    public float gravity = 9.8f;
    CharacterController mController;
    Animator animator;
	// Use this for initialization
	void Start () {
        mController = this.gameObject.GetComponent<CharacterController>();
        animator = this.gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

<<<<<<< Updated upstream
        //animator.SetBool("isDamageTaking", false);

=======
>>>>>>> Stashed changes
        Vector3 movZ = Input.GetAxis("Vertical")
                           * Vector3.forward * moveSpeed;

        Vector3 movX = Input.GetAxis("Horizontal")
                       * Vector3.right * moveSpeed;

        Vector3 mov = transform.TransformDirection(movZ + movX);

        mov.y -= gravity * Time.deltaTime;

        mController.Move(mov);

<<<<<<< Updated upstream
        //animator.SetBool("isRunning", Input.GetAxisRaw("Vertical") != 0);
        //animator.SetBool("isRange", Input.GetButtonDown("e"));
        //       if (Input.GetAxisRaw("Vertical") != 0) {
        //       animator.SetBool("isRunning", true);
        //       }

        //       if (Input.GetAxisRaw("Vertical") == 0)
        //       {
        //           animator.SetBool("isRunning", true);
        //       }
=======
        animator.SetBool("isRunning", Input.GetAxisRaw("Vertical") != 0);
>>>>>>> Stashed changes


    }
}
