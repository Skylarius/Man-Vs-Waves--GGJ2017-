using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour {
	public int point = 0;
	public GameObject money;
	public static PointManager instance = null;
    public int record = 0;

	private int i=0,j=0;

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
	}

	public void addPoint(){
		point++;
		if (point == 2)
			EnemyManager.instance.Initialize ();
		if (point == 10 + 10 * i) {
			EnemyManager.instance.upEnemy ();
			i++;
		}
		if (point == 15 + 10 * j){
			EnemyManager.instance.lowSec ();
			j++;
		}
        if (point > record) record = point;
		moarPoint();
	}

	public void moarPoint(){
		Instantiate (money,new Vector3(Random.Range(-5.5f,5.5f),Random.Range(1,3.5f),0),Quaternion.identity);
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
