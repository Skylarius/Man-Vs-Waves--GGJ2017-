using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivate : MonoBehaviour {
    public GameObject particle;
    private ParticleSystem p;
    void Start()
    {
        p = particle.GetComponent<ParticleSystem>();
    }
    void OnCollisionEnter2D (Collision2D coll)
    {
        p.Emit(10);
        particle.transform.position = coll.contacts[0].point;
        GetComponent<AudioSource>().Play();
    }

    void OnCollisionExit2D (Collision2D coll)
    {
       
    }
}
