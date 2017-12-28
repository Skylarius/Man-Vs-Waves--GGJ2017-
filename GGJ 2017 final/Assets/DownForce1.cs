using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownForceX : MonoBehaviour {

    public float force;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Vertical2"))
        {
            GetComponent<Rigidbody2D>().AddForce(-Vector3.up * force);
        }
    }
}
