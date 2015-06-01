using UnityEngine;
using System.Collections;

public class starMover : MonoBehaviour {


	public float starVelocityMin, starVelocityMax;

	void Update() {
	
		GetComponent<Rigidbody2D>().AddForce (new Vector2 (-Random.Range (starVelocityMin, starVelocityMax), 0));
	}
}
