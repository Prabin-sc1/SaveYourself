using UnityEngine;
using System.Collections;

public class Corona : MonoBehaviour {

	public float rotationSpeed;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void FixedUpdate(){
		transform.Rotate (0,0,rotationSpeed);
	}

	private void OnTriggerEnter2D(Collider2D collision){

		if (collision.gameObject.tag == "Player") {

			Destroy(collision.gameObject);	

			GameManager.instance.GameOver();
		}
		else if(collision.gameObject.tag == "Ground"){
			GameManager.instance.IncrementScore();
			Destroy (gameObject);
		}
	}


}

