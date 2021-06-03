using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	Rigidbody2D rb;

	float xInput;//here i'm storing input value i.e either left arrow key or right arrow key

	Vector2 newPosition; //this variable can store two values(one x value and another y value)

	public float moveSpeed;

	public float xPositionLimit;

	private void Awake(){
		rb = GetComponent<Rigidbody2D> ();
	}


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void FixedUpdate(){
		MovePlayer ();
	}

	void MovePlayer(){

		xInput = Input.GetAxis ("Horizontal");//-1 to +1
	
		newPosition = transform.position;//gives the current position of player
		newPosition.x += xInput * moveSpeed;

		newPosition.x = Mathf.Clamp (newPosition.x, -xPositionLimit, xPositionLimit);


		rb.MovePosition (newPosition);

	}
}
