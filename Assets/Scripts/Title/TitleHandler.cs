using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleHandler : ISceneTransitioner {
	
	[SerializeField]
	private TransitionAnimationType endAnim;

	[SerializeField]
	private float animTime;

	void Start() {
		loadedScene = "Main";
	}


	void Update () {
		if( Input.anyKeyDown ) {
			TransitionScene(endAnim, animTime );
		}
	}
}
