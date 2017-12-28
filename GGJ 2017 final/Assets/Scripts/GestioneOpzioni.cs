using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestioneOpzioni : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void startPlaying(){
        EnemyManager.instance.TwoPlayersMode = false;
        SceneManager.LoadScene(1);
    }

    public void StartMultiPlayer()
    {
        EnemyManager.instance.TwoPlayersMode = true;
        SceneManager.LoadScene(2);
    }

	public void exitGame(){
        Application.Quit();
	}

    public void exitMenu()
    {
        SceneManager.LoadScene(3);
    }
	
    public void OpenImage(GameObject img)
    {
        img.SetActive(true);
    }

    public void CloseImage (GameObject img)
    {
        img.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
