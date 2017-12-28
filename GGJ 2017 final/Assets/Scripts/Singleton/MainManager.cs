using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour {
	public static MainManager instance = null;

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

	public void endGame(){
		PointManager.instance.point = 0;
		EnemyManager.instance.Block ();
		EnemyManager.instance.activated = false;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
