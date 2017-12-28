using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionEnemy : MonoBehaviour {
    Vector3 memory;
    public float border;
	// Use this for initialization
	void Start () {
        memory = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < border) transform.position = memory;
	}
}
