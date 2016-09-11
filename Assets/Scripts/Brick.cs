using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timeHits;
	private LevelManger levelManger;
	
	public static int BrickNum = 0;
	
	// Use this for initialization
	void Start () {
		levelManger = GameObject.FindObjectOfType<LevelManger>();
		timeHits = 0;
		BrickNum += 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		timeHits += 1;
		if(timeHits >= maxHits){
			Destroy(gameObject);
			BrickNum -= 1;
		}
		print(BrickNum);
		if(BrickNum <= 0) levelManger.LoadNextLevel();
	}
}
