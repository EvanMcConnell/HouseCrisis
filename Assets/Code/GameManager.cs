using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int people;
    public static GameManager gameManager;
    private UIManager uiManager;

    private void Awake()
    {
        if(gameManager==null)
        {
            gameManager = this;
            people = 0;
        }
        else if(gameManager != this)
        {
            gameManager.uiManager = FindObjectOfType<UIManager>();
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        uiManager = FindObjectOfType<UIManager>(); ;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void consumePerson()
    {
        people++;
        uiManager.ResetUI();
    }

    public int getPeopleConsumed()
    {
        return people;
    }


}