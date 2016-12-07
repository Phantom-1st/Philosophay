using UnityEngine;
using System.Collections;

public class SlideDoor : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		if (j<1)
		{
			if (Left)
			transform.Translate(Vector3.left*Time.deltaTime);
			else
			transform.Translate(Vector3.right*Time.deltaTime);

			
			j+=0.01f;
		}
	}

	float j = 0;
	public bool Left;
}
