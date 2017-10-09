using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredients_Data : MonoBehaviour {

	//Imgredientに渡すステータス
	public float speed;
	public float hight;
	public float border_right;
	public float border_left;

	public void Init( int num ) {
		speed = getSpeed( num );
		hight = getHight( num );
		border_right = getBorderRight();
		border_left = getBorderLeft();
	}

	float getSpeed( int num ) {
		float value = 0;
		switch( num ) {
			case 0:
				value = 0.1f;
				break;
			case 1:
				value = 0.1f;
				break;
			case 2:
				value = 0.1f;
				break;
			case 3:
				value = 0.1f;
				break;
			case 4:
				value = 0.1f;
				break;
			case 5:
				value = 0.1f;
				break;
			case 6:
				value = 0.1f;
				break;
		}
		return value;
	}

	float getHight( int num ) {
		float value = 0;
		switch( num ) {
			case 0:
				value = -4.5f;
				break;
			case 1:
				value = -3.5f;
				break;
			case 2:
				value = -2.5f;
				break;
			case 3:
				value = -1.5f;
				break;
			case 4:
				value = -0.5f;
				break;
			case 5:
				value = 0.5f;
				break;
			case 6:
				value = 1.5f;
				break;
		}
		return value;
	}

	float getBorderRight() {
		return 7.0f;
	}

	float getBorderLeft() {
		return -7.0f;
	}
}
