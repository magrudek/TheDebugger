using UnityEngine;
using System.Collections;

public class Enemy2DAI : MonoBehaviour {

	bool isGoingLeft = false;
	Vector3 _originalPosition;
	protected Vector3 velocity;
	public Transform _transform;
	public float distance = 1f;
	public float speed = 1f;

	void Update()
	{    
		float distFromStart = transform.position.x - _originalPosition.x;   
		
		if (isGoingLeft)
		{ 
			// If gone too far, switch direction
			if (distFromStart < -distance)
				SwitchDirection();
			
			_transform.Translate (velocity.x * Time.deltaTime, 0, 0);
		}
		else
		{
			// If gone too far, switch direction
			if (distFromStart > distance)
				SwitchDirection();
			
			_transform.Translate (-velocity.x * Time.deltaTime, 0, 0);
		}
	}
	
	void SwitchDirection()
	{
		isGoingLeft = !isGoingLeft;
		//TODO: Change facing direction, animation, etc
	}
}
