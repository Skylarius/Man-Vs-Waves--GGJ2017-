using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeManager : MonoBehaviour {
    LineRenderer l;
    public GameObject start;
    public float offset=0.1f;

	// Use this for initialization
	void Start () {
        l = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        l.SetPosition(0, start.transform.position + Vector3.forward*offset);
        l.SetPosition(1, transform.position + Vector3.forward*offset);
    }
}
