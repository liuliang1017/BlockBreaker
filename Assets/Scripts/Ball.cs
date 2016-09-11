using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 ballToPaddle;
	private bool hasStarted = false;
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>(); 
		ballToPaddle = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(hasStarted == false){
			this.transform.position = paddle.transform.position + ballToPaddle;
			if(Input.GetMouseButtonDown(0)){
				this.rigidbody2D.velocity = new Vector2(2f, 10f);
				hasStarted = true;
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		Vector2 tweak = new Vector2(Random.Range(0.1f, 0.3f), Random.Range(0.1f, 0.3f));
		this.rigidbody2D.velocity += tweak;
	}
	
}
