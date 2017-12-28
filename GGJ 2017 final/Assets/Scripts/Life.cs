using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {
	public int vite = 3;

    public GameObject ObjectToRelease;
    public GameObject GameOver;
    private bool isDead = false;
	// Use this for initialization
	void Start () {
		
	}

	public void loseLife(){
		vite--;
        if (vite <= 0)
        {
            StartCoroutine("Morte");
        }
	}

    IEnumerator Morte()
    {
        ObjectToRelease.transform.parent = null;
        ObjectToRelease.GetComponent<Rigidbody2D>().gravityScale = 0.5f;
        ObjectToRelease.GetComponent<Rigidbody2D>().AddForce(new Vector2(-300, 300), ForceMode2D.Force);
        GetComponent<WindForce>().Force *= 20;
        GetComponent<Rotate>().rotate = true;
        yield return new WaitForSeconds(2f);
        if (isDead==false) GameOver.SetActive(true);
        isDead = true;
        yield return new WaitForSeconds(0.1f);
        MainManager.instance.endGame();
    }

	// Update is called once per frame
	void Update () {
		
	}
}
