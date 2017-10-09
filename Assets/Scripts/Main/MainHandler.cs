using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHandler : ISceneTransitioner {

	[SerializeField]
	private TransitionAnimationType endAnim;

	[SerializeField]
	private float animTime;

	void Start() {
		loadedScene = "Title";
	}


	void Update() {
		if( Input.GetKeyDown( KeyCode.S ) || Input.GetKeyDown( KeyCode.F ) ) {
			if( Input.GetKeyDown( KeyCode.S ) ) {
				loadedScene = "Success";
			}
			if( Input.GetKeyDown( KeyCode.F ) ) {
				loadedScene = "Failure";
			}
			TransitionScene( endAnim, animTime );
		}
	}
}
