using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDx1 : MonoBehaviour {

    public float speed = 200;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Rotation");
        //if (x > 0) 
        //{
        float mov = -Time.deltaTime * x * speed;
        gameObject.transform.Rotate(0, 0, mov);

        //}
    }
}
