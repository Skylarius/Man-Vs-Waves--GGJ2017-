using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour {
	public bool hit = true;
	public float limitX = 10;
	public float limitY = 6.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs (transform.position.x) > limitX || Mathf.Abs (transform.position.y) > limitY)
			Destroy (this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player") && hit) {
			other.gameObject.GetComponent<Life>().loseLife ();
			hit = false;
		}
	}

	void setHit(bool h){
		hit = h;
	}
}
