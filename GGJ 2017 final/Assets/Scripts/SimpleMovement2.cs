using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement2 : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal2");
        transform.position += Time.deltaTime * Vector3.right * x * speed;
    }
}
