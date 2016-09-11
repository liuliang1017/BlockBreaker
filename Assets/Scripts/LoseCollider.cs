using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	
	private LevelManger levelManger;
	void Start(){
		levelManger = GameObject.FindObjectOfType<LevelManger>();
	}

	void OnTriggerEnter2D(Collider2D collider){
		levelManger.LoadLevel("Lose");
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		Brick.BrickNum = 0;
		levelManger.LoadLevel("Lose");
	}
}
