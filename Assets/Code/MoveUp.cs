using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {
    public float screenScrollSpeed;

    // Use this for initialization
    private

  

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, screenScrollSpeed));

    }
}
