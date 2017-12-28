using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMoveAndRotate : MonoBehaviour
{
    public Vector3 worldPoint;
    private float offsetRay = 90;
    public float offsetHeight = 1;
    public float offsetWidth = 1;
    public float speedRotation = 1;
    public float maxAngle = 100;
    public float minAngle = 20;
    public float amplitudeRotation = 70;
    public float offsetAngle = 10;
    private float y1=0, y2=0;
    public LayerMask layerMask = 1 << 8;
    // Use this for initialization
    void Start()
    {
        transform.Rotate(Vector3.forward * offsetAngle);
        y1 = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position+Vector3.up*offsetRay, Vector3.down, 100f, layerMask);
        if (hit.collider.gameObject.CompareTag("Water"))
        {
            transform.position = hit.point + Vector2.up * offsetHeight;
            //if (transform.eulerAngles.z < minAngle && transform.eulerAngles.z > -minAngle)
            if ((y2-y1)*amplitudeRotation < maxAngle && (y2 - y1) * amplitudeRotation> minAngle) transform.eulerAngles = Vector3.forward * (y2 - y1) * amplitudeRotation;
        }
        y1 = y2;
        y2 = transform.position.y;

    }
}
