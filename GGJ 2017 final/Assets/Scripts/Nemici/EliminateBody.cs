using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminateBody : MonoBehaviour {
	public float sec = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other){
		StartCoroutine ("Die");
	}


	IEnumerator Die(){
		yield return new WaitForSeconds (sec);
		Destroy (this.gameObject);
	}
}
