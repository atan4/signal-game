using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	// The Ship
	public GameObject signal;

	// The Interval
	public float interval = 1;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnNext", interval, interval);
	}

	void SpawnNext () {
		Instantiate(signal, transform.position, Quaternion.identity);
	}
}