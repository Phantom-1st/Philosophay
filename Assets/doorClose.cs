using UnityEngine;
using System.Collections;

public class doorClose : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.PlayDelayed(.3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
