using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuvola : MonoBehaviour {
	public int velX = 3;
	public float start = 10;

	public float maH = 3.5f;
	public float miH = -1;
	public float limit = -10;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (Random.Range(10,30), Random.Range (miH, maH), 0);
	}

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-Time.deltaTime * velX, 0, 0);
		if (transform.position.x < limit) {
			transform.position = new Vector3 (Random.Range(10,30), Random.Range (miH, maH), 0);
		}
	}
}
