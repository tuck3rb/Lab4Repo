using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderSteer : MonoBehaviour
{
	public float speed;
	public float angle;

	private Rigidbody2D body;

	// Use this for initialization
	void Start()
	{
		body = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		body.AddForce(transform.up * speed);
		transform.Rotate(Vector3.back * (Random.value * 2 * angle - angle));
		if (Mathf.Abs(transform.position.y) >= 25) {
			transform.position = new Vector2(Random.Range(-40f, 40f), -25);
		}
	}
}
