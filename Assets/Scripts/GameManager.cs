using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour {
  
	public static GameManager instance;
     	bool gameOver = false;
	    int score = 0;


	private void Awake(){
		if (instance == null) {
			instance = this;		
		}
	}

	public void GameOver(){
		gameOver = true;

		GameObject.Find ("CoronaSpawns").GetComponent<CoronaSpawn>().StopSpawning ();
	
	}

	
	public void IncrementScore(){
		if (!gameOver) {
		     score++;
			print (score);
		}
	}
	void OnGUI(){
		GUI.color = Color.black;
		GUILayout.Label ("Score: " + score.ToString());
	}


}
