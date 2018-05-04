using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public const float RUN_SPEED = ((float)(0.17 / 8) * 1000);

    private Rigidbody2D body;
    private Vector2 velocity;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate()
	{
        if (Input.GetKey(KeyCode.RightArrow)) {
            velocity.x = RUN_SPEED;
        }
        else {
            velocity.x = 0;
        }
        Movement(velocity);
	}

    void Movement(Vector2 move)
    {
        body.position = body.position + move * Time.deltaTime;
    }
}
