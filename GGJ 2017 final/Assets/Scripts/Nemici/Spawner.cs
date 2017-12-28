using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public float maX = 6;
	public float miX = -6;
	public float height = 6.4f;
	// Use this for initialization
	void Start () {
		gameObject.transform.position = new Vector3 (Random.Range(miX,maX),height,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
