using UnityEngine;
using System.Collections;

public class Enemy2D : MonoBehaviour {

	float startingPos;
	float endPos;
	public int unitsToMove = 5;
	public int moveSpeed = 2;
	bool moveRight = true;
	
	void Awake(){
		startingPos = transform.position.x;
		endPos = startingPos + unitsToMove;
	}
	
	int damageValue = 1;
	
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (moveRight) {
			rigidbody.position += Vector3.right * moveSpeed * Time.deltaTime;
		}
		
		if (rigidbody.position.x >= endPos) {
			moveRight = false;		
		}
		
		if (moveRight) {
			rigidbody.position -= Vector3.right * moveSpeed * Time.deltaTime;		
		}
		
		if (rigidbody.position.x <= startingPos) {
			moveRight = true;		
		}
	}
}
