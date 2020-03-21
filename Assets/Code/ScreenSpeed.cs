using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSpeed : MonoBehaviour {

    public float speed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
        Debug.Log(speed);
    }
   
}
