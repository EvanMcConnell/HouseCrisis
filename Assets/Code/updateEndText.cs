using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateEndText : MonoBehaviour {

    public Text peopleNumber;

    // Use this for initialization
    void Start () {
        peopleNumber.text = GameManager.gameManager.getPeopleConsumed().ToString();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
