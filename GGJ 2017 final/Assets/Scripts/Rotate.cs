using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float Force = 10;
    public bool rotate = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (rotate)transform.eulerAngles += Vector3.forward * Force*Time.deltaTime;
	}
}
