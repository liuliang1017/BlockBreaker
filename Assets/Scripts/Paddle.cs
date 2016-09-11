using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	//private Ball ball; // used for debug
	// Use this for initialization
	void Start () {
		//ball = GameObject.FindObjectOfType<Ball>();//used for debug
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3 (0.5f, 1.0f, 0f);
		float mousePosInBlocks = Mathf.Clamp((Input.mousePosition.x / Screen.width) * 16, 0.5f, 15.5f);
		paddlePos.x = mousePosInBlocks;
		this.transform.position = paddlePos;
		//Vector3 tempPos = new Vector3(ball.transform.position.x, 1.0f, 0f); //used for debug
		//this.transform.position = tempPos; // used for debug
	}
}
