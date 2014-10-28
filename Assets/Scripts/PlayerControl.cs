using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
	private bool isOnGround;

	void Start()
	{	
		isOnGround = true;
	}

	void Update()
	{
		Movement();
	}

	void Movement()
	{
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
		}
	
		if (Input.GetKey (KeyCode.A)){
			transform.Translate (Vector3.right * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 180);
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			if(isOnGround = true)
			{
				rigidbody2D.AddForce (Vector2.up * 200f);
				isOnGround = false;
			}
		}
	}

	void onCollisionEnter2D(Collision col)
	{
		if (col.gameObject.tag == "Cave")
		{
			isOnGround = true;
		}
	}
}
