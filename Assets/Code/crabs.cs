using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crabs : MonoBehaviour {

    public Animator anim;
	// Use this for initialization
	void Start () {

        anim = gameObject.GetComponent<Animator>();
       
	}
	
	// Update is called once per frame
	void Update () {
        
        GameObject gameManager = GameObject.Find("GameManager");
        ScreenSpeed screenSpeed = gameManager.GetComponent<ScreenSpeed>();
        anim.speed = screenSpeed.speed*2;
    }
}
