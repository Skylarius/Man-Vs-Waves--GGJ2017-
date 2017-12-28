using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour {
    public float speed=1;
    public float border = 10;
    public int NumberOfWaves;
    public float Offset = 0.5f;
    private float jumpOffset=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Transform childTransform in GetComponentsInChildren<Transform>())
        {
            if (childTransform.gameObject!=gameObject) {
                childTransform.position -= Vector3.right * speed * Time.deltaTime;
                //if (childTransform.position.x < border) childTransform.position += Vector3.right * NumberOfWaves * childTransform.gameObject.GetComponent<Collider2D>().bounds.size.x - Vector3.right * Offset;
                if (childTransform.position.x < border)
                {
                    for (int i = 0; i < NumberOfWaves; i++)
                    {
                        float waveWidth = transform.GetChild(i).gameObject.GetComponent<Collider2D>().bounds.size.x;
                        jumpOffset += waveWidth;
                    }
                    childTransform.position += Vector3.right * (jumpOffset - Offset);
                    jumpOffset = 0;
                }
            }
        }
    }
}
