using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpForce : MonoBehaviour {
	public float forceUp=50;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag ("Water")) 
		{
			GetComponent<Rigidbody2D> ().AddForce (Vector3.up * forceUp);
		}
	}
}
