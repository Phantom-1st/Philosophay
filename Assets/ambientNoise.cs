using UnityEngine;
using System.Collections;

public class ambientNoise : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.PlayDelayed(3f);
	}
}