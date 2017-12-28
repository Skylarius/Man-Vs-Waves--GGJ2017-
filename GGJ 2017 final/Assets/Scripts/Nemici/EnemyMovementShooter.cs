using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementShooter : MonoBehaviour {
	public int velX = 2;
	public float start = 10;
	public float maxDist = 6;
	public float maH = 3.5f;
	public float miH = -1;
	public float sec = 2;
	public bool advance = true;
	public bool shoot = false;
	public GameObject [] projectile;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (start, Random.Range (miH, maH), 0);

	}
	
	// Update is called once per frame
	void Update () {
		if (advance == true) {
			transform.position += new Vector3 (-Time.deltaTime * velX, 0, 0);
			if (transform.position.x < maxDist && !shoot) {
				StartCoroutine ("myLife");
				advance = false;
			}
			if (transform.position.x > start && shoot) {
				Destroy (this.gameObject);
			}
		}
	}

	IEnumerator myLife(){
		yield return new WaitForSeconds(sec/2);
		int p = Random.Range (0, projectile.Length);
		Instantiate (projectile[p], transform.position, Quaternion.identity);
		shoot = true;
		yield return new WaitForSeconds (sec / 2);
		velX = -velX;
		advance = true;
	}
}
