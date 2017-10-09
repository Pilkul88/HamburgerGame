using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient_State : MonoBehaviour {

	public enum Ingredient_States {
		STANDBY,
		STARTUP,
		ACTIVE,
		STOP,
		INACTIVE
	}

	[SerializeField]
	Ingredient_States nowState = Ingredient_States.STANDBY;

	[SerializeField]
	public int ingredient_Number;

	private float speed;
	private float hight;
	private float border_right;
	private float border_left;

	void Start() {
		Ingredients_Data status = new Ingredients_Data();
		status.Init( ingredient_Number );

		speed = status.speed;
		hight = status.hight;
		border_right = status.border_right;
		border_left = status.border_left;
		IngredientsActiveController.Instance.setIngredient( ingredient_Number, this.gameObject );
	}
	
	// Update is called once per frame
	void Update () {

		switch( nowState ) {
			case Ingredient_States.STANDBY:
				break;
			case Ingredient_States.STARTUP:
				StartUp();
				break;
			case Ingredient_States.ACTIVE:
				Active();
				break;
			case Ingredient_States.STOP:
				Stop();
				break;
			case Ingredient_States.INACTIVE:
				break;
		}
	}

	void StartUp() {
		transform.position = new Vector3( 0, hight, 0 );
		setState( Ingredient_States.ACTIVE);
	}

	void Active() {
		transform.position += new Vector3( speed, 0, 0 );
		float posX = transform.position.x;
		if( posX < border_left || border_right < posX ) {
			speed *= -1;
		}

		//Input関連
		if( Input.GetKeyDown(KeyCode.Return) ) {
			setState(Ingredient_States.STOP);
		}
	}

	void Stop() {
		IngredientsActiveController.Instance.setNextIngredient(ingredient_Number);
		setState( Ingredient_States.INACTIVE );
	}

	public void setState( Ingredient_States state ) {
		nowState = state;
	}
}
