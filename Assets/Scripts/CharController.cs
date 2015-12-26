using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

	float maxSpeed = 10f;
	float dashSpeed= 50f;
	
	// fixedUpdate takes into account time, so no time.deltatime necessary
	void Update(){
		if (Input.GetMouseButtonDown (0)) {
		dash ();
		}
	}
	// fixedUpdate takes into account time, so no time.deltatime necessary
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity= new Vector2(move* maxSpeed,GetComponent<Rigidbody2D>().velocity.y  );
	}
	void dash() {
		Vector3 mouseDirection;
		mouseDirection = Input.mousePosition;
		mouseDirection.z = 0.0f;
		mouseDirection = Camera.main.ScreenToWorldPoint(mouseDirection);
		mouseDirection = (mouseDirection-transform.position).normalized;
		GetComponent<Rigidbody2D>().velocity =new Vector2(mouseDirection.x*dashSpeed,mouseDirection.y*dashSpeed);

	}

}
