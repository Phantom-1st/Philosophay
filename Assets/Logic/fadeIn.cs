using UnityEngine;
using System.Collections;

public class fadeIn : MonoBehaviour
{
	public float fadeSpeed = 0.8f;
	private float alpha = 1f;
	public GameObject go;

	void Start ()
	{
		alpha = 1;
		Debug.Log ("alpha at start: " + alpha);

	}


	void Update ()
	{
		FromBlack ();
	}

	void FromBlack ()
	{
		Renderer rend = go.GetComponent<Renderer> ();

		if (alpha > 0) {
			alpha -= fadeSpeed * Time.deltaTime;
			Mathf.Clamp01 (alpha);
			rend.material.SetColor ("_Color", new Color (0, 0, 0, alpha));
			//rend.material.color.a = alpha;
		}
	}

	/*void OnGUI() 
	{
		//if (GUILayout.Button("Press Me"))
	}*/
}