using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float speed;
	public float s =0;
	private Rigidbody2D rigidBody2D;
	// Use this for initialization
	void Start () {
		rigidBody2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)){
			rigidBody2D.AddForce(Vector2.right*speed);
			transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
		}

		if (Input.GetKey(KeyCode.LeftArrow)){
			rigidBody2D.AddForce(-Vector2.right*speed);
			transform.rotation=Quaternion.Euler(new Vector3(0,0,180));
		}

		if (Input.GetKey(KeyCode.UpArrow)){
			rigidBody2D.AddForce(Vector2.up*speed);
			transform.rotation=Quaternion.Euler(new Vector3(0,0,90));
		}

		if (Input.GetKey(KeyCode.DownArrow)){
			rigidBody2D.AddForce(-Vector2.up*speed);
			transform.rotation=Quaternion.Euler(new Vector3(0,0,270));
		}
		s = rigidBody2D.velocity.magnitude;
	}
}
