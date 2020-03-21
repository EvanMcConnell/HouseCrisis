using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HumanCollector : MonoBehaviour {
    public int score;
    
    // Use this for initialization
    void Start () {
        UpdateUI();

       
    }

    // Update is called once per frame
    void Update () {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = GameObject.Find("Player");
        PlayersMovement playersMovement = player.GetComponent<PlayersMovement>();

        if (collision.collider.gameObject.CompareTag("PickUp")) { 
        Destroy(collision.collider.gameObject);

			SoundManagerScript.PlaySound ("slurp");
            transform.localScale += new Vector3(.03F, .03F, 0);
            GameManager.gameManager.consumePerson();
            print("People = " + GameManager.gameManager.getPeopleConsumed());
            playersMovement.jumpForce =  120f + playersMovement.jumpForce;
            playersMovement.Speed = .2f + playersMovement.Speed;
        } 
      
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Die")
        {
            Debug.Log("THere is no god");
            SceneManager.LoadScene("EndScene");
        }
		if (collider.gameObject.tag == "end")
		{
			Debug.Log("THere is a god");
			SceneManager.LoadScene("winRate");
		}


    }

    void UpdateUI ()
    {
    }
   
}
