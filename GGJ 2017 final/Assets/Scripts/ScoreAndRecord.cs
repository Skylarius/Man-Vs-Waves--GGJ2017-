using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAndRecord : MonoBehaviour {
    public Text score, record;
	// Use this for initialization
	void Start () {
        score.text=PointManager.instance.point.ToString();
        record.text = PointManager.instance.record.ToString();
	}
	
	
}
