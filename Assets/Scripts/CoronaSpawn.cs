using UnityEngine;
using System.Collections;

public class CoronaSpawn : MonoBehaviour {
	public float spawnRate;

	public GameObject corona;
	public float xPositionLimit;
	// Use this for initialization
	void Start () {

		//SpawnCorona ();
		StartSpawning ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void SpawnCorona(){

		float randomX = Random.Range (-xPositionLimit,xPositionLimit);

		Vector2 spawnPosition = new Vector2 (randomX, transform.position.y);
		Instantiate (corona, spawnPosition, Quaternion.identity);//Quaternion means zero


	}
	 void StartSpawning(){

		InvokeRepeating ("SpawnCorona",0.2f,spawnRate);

	}
	public void StopSpawning(){

		CancelInvoke("SpawnCorona");
	}
}
