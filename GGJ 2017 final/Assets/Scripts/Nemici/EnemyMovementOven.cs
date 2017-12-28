using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementOven : MonoBehaviour {
	public float start = 10;
	public float maX = 200;
	public float miX = 100;
	public float maY = 200;
	public float miY = 100;
	public float maR = 60;
	public float miR = 10;
	public float maH = 3.5f;
	public float miH = -1;

	// Use this for initialization

	//Aggiungere questo script insieme ad un Rigidbody2D e a un Collider2D non Triggered. Assegnare al gameObject il Layer Nemico
	void Start () {
		gameObject.transform.position = new Vector3 (start,Random.Range(miH,maH),0);
		gameObject.transform.Rotate(new Vector3(0,0,-Random.Range(miR,maR)));
		gameObject.GetComponent<Rigidbody2D> ().AddForce(new Vector2(Random.Range (-miX, -maX), Random.Range (maY, miY)));
	
	}
	
	// Update is called once per frame
	void Update () {
	}

}
