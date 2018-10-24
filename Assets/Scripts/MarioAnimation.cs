using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioAnimation : MonoBehaviour {

    private Animator animator;

	void Start()
	{
        animator = GetComponent<Animator>();
	}

	void Update()
	{
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("isRunning", true);
        } 

        else 
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isRunning", false); 
            animator.SetBool("jump", true);
        }


	}
}
