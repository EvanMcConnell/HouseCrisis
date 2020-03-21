using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	public static AudioClip jump, slurp, tickets;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		jump = Resources.Load<AudioClip> ("jump");
		slurp = Resources.Load<AudioClip> ("slurp");
		tickets = Resources.Load<AudioClip> ("tickets");

		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound (string clip){
		switch(clip){
		case "jump":
			audioSrc.PlayOneShot (jump);
			break;
		
		case "slurp":
			audioSrc.PlayOneShot (slurp);
			break;

		case "tickets":
			audioSrc.PlayOneShot (tickets);
			break;
		}
	}
}
