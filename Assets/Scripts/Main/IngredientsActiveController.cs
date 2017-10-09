using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsActiveController : SingletonMonoBehaviour<IngredientsActiveController> {

	[SerializeField]
	private int ingredientsAmount = 0;

	GameObject[] ingredients;

	void Awake () {
		ingredients = new GameObject[ingredientsAmount];
	}

	void Start() {
		ingredients[0].GetComponent<Ingredient_State>().setState( Ingredient_State.Ingredient_States.STARTUP );
	}

	public void setIngredient(int num, GameObject ingredient) {
		if( num > ingredientsAmount )
			return;

		ingredients[num] = ingredient;
	}

	public void setNextIngredient( int num ) {
		if( num + 1 >= ingredientsAmount )
			return;

		ingredients[num + 1].GetComponent<Ingredient_State>().setState(Ingredient_State.Ingredient_States.STARTUP);
	}


}
