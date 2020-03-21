using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControlButtons : MonoBehaviour {

    public GameManager gameManager;

    public void StartLevel1()
    {


        GameObject gameManag = GameObject.Find("GameManager");
        gameManager = gameManag.GetComponent<GameManager>();
        gameManager.people = 0;
		StartCoroutine(Wait (4));
    }

	IEnumerator Wait(float waitTime){
		SoundManagerScript.PlaySound ("tickets");
		yield return new WaitForSeconds (waitTime);
		SceneManager.LoadScene("CocaCola");
	}

    public void StartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

	public void credits()
	{
		SceneManager.LoadScene ("Credits");
	}
}
