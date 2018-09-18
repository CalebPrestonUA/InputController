using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    public Transform lily;
    public float speed;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = lily.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("I collided with " + other.name);
    }
}
