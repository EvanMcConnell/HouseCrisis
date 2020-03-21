using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    // Use this for initialization
    public Text vorePeople;

	void Start () {

        ResetUI();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetUI()
    {
        vorePeople.text ="People: " + GameManager.gameManager.getPeopleConsumed();
    }
}
