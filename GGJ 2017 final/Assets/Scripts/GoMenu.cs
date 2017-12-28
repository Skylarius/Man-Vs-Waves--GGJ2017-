using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("Inizia");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Inizia() {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }
}
