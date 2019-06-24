using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {


    public GameObject Ball;
    public GameObject leftPlayer;
    public GameObject rightPlayer;
    public GlobalScript globalScript;
    bool isLeftDeadZone; 

    // Use this for initialization
    void Start () {

        isLeftDeadZone = gameObject.name == "LeftDeadZone";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
