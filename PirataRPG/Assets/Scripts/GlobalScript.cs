using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour {

    public int leftScore;
    public int rightScore;
    public TextMesh leftScoreText;
    public TextMesh rightScoreText;

    // Use this for initialization
    void Start () {
        leftScore = 0;
        rightScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void IncrementarScore(bool isLeftPlayer)
    {

        if (isLeftPlayer)
        {
            leftScore++;
        }

    }
}
