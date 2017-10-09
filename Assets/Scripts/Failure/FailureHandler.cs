using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailureHandler : ISceneTransitioner {

	[SerializeField]
	private TransitionAnimationType endAnim;

	[SerializeField]
	private float animTime;

	void Start() {
		loadedScene = "Title";
	}


	void Update() {
		if( Input.GetKeyDown( KeyCode.T ) || Input.GetKeyDown( KeyCode.R ) ) {
			if( Input.GetKeyDown( KeyCode.T ) ) {
				loadedScene = "Title";
			}
			if( Input.GetKeyDown( KeyCode.R ) ) {
				loadedScene = "Main";
			}
			TransitionScene( endAnim, animTime );
		}
	}
}
