using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ISceneTransitioner : MonoBehaviour {

	public string loadedScene; //ロードするシーン

	/// <summary>
	/// アニメーションの種類
	/// </summary>
	public enum TransitionAnimationType {
		NONE,
		FADE
	}

	/// <summary>
	/// シーンを遷移させる
	/// </summary>
	public void TransitionScene(TransitionAnimationType endAnim, float animTime ) {

		//遷移時のアニメーションがあるか
		if( endAnim != TransitionAnimationType.NONE ) {
			GameObject animationScreen = GameObject.Find( "ScreenEffectPanel" ); 
			if(animationScreen == null ) {
				GameObject screenEffectPanel = ( GameObject )Resources.Load( "Prefabs/ScreenEffectPanel" );
				animationScreen = Instantiate(screenEffectPanel);
			}
			animationScreen.GetComponent<ScreenAnimations>().executeAnimation(endAnim.ToString());
		}

		Invoke( "load", animTime );
	}

	private void load() {
		SceneManager.LoadScene( loadedScene );
	}

}
