using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDx : MonoBehaviour {
 	public float speed = 200;
	public float counter;

	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Rotation");
		//if (x > 0) 
		//{
		float mov = -Time.deltaTime*x*speed;
		gameObject.transform.Rotate (0, 0, mov);
		counter += mov;
		if (Mathf.Abs(counter) >= 360){
			PointManager.instance.addPoint();
			counter = 0;
		}
		//}
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag ("Water")) 
		{
			counter = 0;
		}
	}
}
