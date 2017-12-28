using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementCloud : MonoBehaviour {
	public int velX = 2;
	public float start = 10;
	public float maxDist = -10f; //Indica quanto lontano deve essere l'oggetto per essere distrutto
	public float height = 4;
	public float min = -6;
	public float max = 6;
	public float sec = 1;
	private bool moving = true;
	private bool shoot = false;
	private float zone;
	public GameObject [] projectile;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(start, height, 0);
		zone = Random.Range (-6,6);
	}
	
	// Update is called once per frame
	void Update () {
		if (moving) {
			transform.position += new Vector3 (-Time.deltaTime * velX, 0, 0);
			if (transform.position.x < maxDist)
				Destroy (this.gameObject);
			if (transform.position.x < zone && !shoot) {
				StartCoroutine ("spara");
				moving = false;
			}
		}

	}

	IEnumerator spara(){
		yield return new WaitForSeconds (sec / 2);
		int p = Random.Range (0, projectile.Length);
		Instantiate(projectile[p],transform.position,projectile[p].transform.rotation);
		yield return new WaitForSeconds (sec / 2);
		moving = true;
		shoot = true;
	}

}
