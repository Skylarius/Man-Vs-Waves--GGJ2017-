using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveGenerator : MonoBehaviour {
    public GameObject WaveToChangeVector;
    private WaveManager wm;

    // Use this for initialization
    void Start () {
        wm = GetComponent<WaveManager>();
        StartCoroutine("ChangeWave");
	}
	
	// Update is called once per frame
	void Change () {
        int i1 = LastPosition();
        int dimension = WaveToChangeVector.transform.GetComponentsInChildren<Transform>().Length;
        int i2 = Random.Range(0, dimension - 1);

        //Scambia oggetti
        GameObject obj1 = wm.gameObject.transform.GetChild(i1).gameObject;
        GameObject obj2 = WaveToChangeVector.transform.GetChild(i2).gameObject;
        Vector3 temp = obj1.transform.position;
        obj1.transform.position = obj2.transform.position;
        obj2.transform.position = temp;

        obj1.transform.SetParent(WaveToChangeVector.transform);
        obj2.transform.SetParent(wm.gameObject.transform);
    }

    int LastPosition()
    {
        float xMax = 0;
        int indexMax=0;
        int lenght = wm.gameObject.transform.GetComponentsInChildren<Transform>().Length - 1;
        for (int i = 0; i< lenght; i++)
        {
            GameObject g = wm.gameObject.transform.GetChild(i).gameObject;
            if (g.transform.position.x>xMax)
            {
                xMax = g.transform.position.x;
                indexMax = i;
            }
        }
        return indexMax;
    }

    IEnumerator ChangeWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Change();
        }
    }


}
