using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementProjectile : MonoBehaviour {
	public int velX = 3;
	public float start = 10;
	public float maxDist = -10f; //Indica quanto lontano deve essere l'oggetto per essere distrutto
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-Time.deltaTime * velX, 0, 0);
		if (transform.position.x < maxDist)
			Destroy (this.gameObject);
	}
}
