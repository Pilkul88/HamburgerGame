using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenAnimations : MonoBehaviour {

	void Start() {
		Transform canvas = GameObject.Find( "Canvas" ).transform;
		transform.parent = canvas;
	}

	public void executeAnimation(string anim) {

	}


	public IEnumerator FadeOut( float executionTime ) {

		yield return new WaitForSeconds( executionTime );

	}
}
