using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	// Movement Speed
	public float speed = 3;

	// Current movement Direction
	Vector2 dir = Vector2.right;

	// Upwards push force
	public float upForce = 800;

	void FixedUpdate() {
		// Set the Velocity
		GetComponent<Rigidbody2D>().velocity = dir * speed;
	}

	void OnTriggerEnter2D(Collider2D coll) {
		// Hit a destination? Then move into other direction
		if (coll.gameObject.name == "buffer") {

			transform.localScale = new Vector2 (-1 * transform.localScale.x,
				transform.localScale.y);

			// And mirror it
			dir = new Vector2 (-1 * dir.x, dir.y);
		}

		if (coll.gameObject.name == "buffer1") {

			transform.localScale = new Vector2 (-1 * transform.localScale.x,
				transform.localScale.y);

			// And mirror it
			dir = new Vector2 (-1 * dir.x, dir.y);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		// Collided with BabyMario?
		if (coll.gameObject.name == "girl_0") {
			// Is the collision above?
			if (coll.contacts[0].point.y > transform.position.y) {
				// Play Animation
//				GetComponent<Animator>().SetTrigger("Died");
//
//				// Disable collider so it falls downwards
//				GetComponent<Collider2D>().enabled = false;
//
//				// Push BabyMario upwards
//				coll.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * upForce);
				coll.gameObject.GetComponent<Rigidbody2D>().velocity = dir * speed;

				// Die in a few seconds
//				Invoke("Die", 5);
			} else {
				// Kill BabyMario
				Destroy(coll.gameObject);
				Application.LoadLevel("Gameover.unity");
			}
		}
	}

	void Die() {
		Destroy(gameObject);
	}
}