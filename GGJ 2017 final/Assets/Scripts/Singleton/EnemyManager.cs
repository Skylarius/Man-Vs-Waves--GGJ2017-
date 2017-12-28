using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
	public bool activated = false;
	public float sec = 10;
	public float psec = 0.5f;
	public float minSec = 3;
	public GameObject[] arrei;
	public static EnemyManager instance;
	public int NN = 2;
	private int numNemici = 2;
    public bool TwoPlayersMode = false;

	void Awake() 
	{
		if (instance == null) 
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else if(instance != this)
		{
			Destroy(this);
			return;
		}
        if (TwoPlayersMode) StartCoroutine("DecreaseSec");
    }
	// Use this for initialization
	void Start () {
		numNemici = NN;
		if (numNemici > arrei.Length)
			numNemici = arrei.Length;
	}
	
	// Update is called once per frame
	void Update () {
		if (activated) {
			StartCoroutine ("spawn");
			activated = false;
		}
	}

	public void Initialize(){
		activated = true;
	}

	public void Block(){
		StopCoroutine ("spawn");
		numNemici = NN;
	}

	public void upEnemy(){
		if (numNemici <= arrei.Length) numNemici++;
	}

	public void lowSec(){
		if (sec >= minSec) sec -= psec;
	}

	IEnumerator spawn(){
		yield return new WaitForSeconds (sec);
		int nemico = Random.Range (0, numNemici);
		Instantiate (arrei[nemico], arrei[nemico].transform.position ,Quaternion.identity);
		activated = true;
	}

    IEnumerator DecreaseSec()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            lowSec();
        }
    }
}
