using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

	float maxspeed = 10f;
	
	// fixedUpdate takes into account time, so no time.deltatime necessary
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity= new Vector2(move* maxspeed, 0);
	}
}
