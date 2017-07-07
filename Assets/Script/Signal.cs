using UnityEngine;
using System.Collections;

public class Signal : MonoBehaviour {
	//keep track of score
	public int score = 0;

	void OnTriggerEnter2D(Collider2D coll) {
		// Destroy the coin
		if (coll.gameObject.name == "girl_0") {
			Destroy (gameObject);
			score += 1;
		}
	}
}
