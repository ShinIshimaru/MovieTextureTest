using UnityEngine;
using System.Collections;

public class MovieCube : MonoBehaviour {

	public MovieTexture movTexture;

	// Use this for initialization
	void Start () {
		renderer.material.mainTexture = movTexture;
		movTexture.Play ();
	}
	
	// Update is called once per frame
	void Update () {

		if (!movTexture.isPlaying) {
			movTexture.Stop ();
			movTexture.Play ();
		}

		//renderer.material.mainTexture.Play();
		float theta = Time.time * Mathf.PI/180*20;

		transform.rotation *= Quaternion.Euler(1, 1, 0);

	}
}
