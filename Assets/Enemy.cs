﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private Animator animator;
    public float speed;
    public LayerMask isGround;
    public Transform wallHitBox;
    private bool wallHit;

    public float wallHitHeight;
    public float wallHitWidth;

	void Start()
	{
        animator = GetComponent<Animator>();
	}

	void FixedUpdate()
	{
        transform.Translate(speed * Time.deltaTime, 0, 0);


        wallHit = Physics2D.OverlapBox(wallHitBox.position, new Vector2(wallHitWidth, wallHitHeight), 0, isGround);

        if (wallHit == true)
        {
            speed = speed * -1;
        }    
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.collider.tag == "Player")
        {
            Debug.Log("I loved living");
            Destroy(gameObject);
        }    
	}

	private void OnDrawGizmosSelected()
	{
        Gizmos.color = Color.red;
        Gizmos.DrawCube(wallHitBox.position, new Vector3(wallHitWidth, wallHitHeight, 1));    
	}
}
