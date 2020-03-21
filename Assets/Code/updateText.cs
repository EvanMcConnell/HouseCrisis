using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateText : MonoBehaviour {

    public static int PeopleValue = 0;
    private static updateText updatetext;
    Texture people;

   
    // Use this for initialization
    void Start () {
        GameObject peopleText = GameObject.Find("PeopleText");
//people = peopleText.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
