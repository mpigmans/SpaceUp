﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableTile : MonoBehaviour {

	public int tileX;
	public int tileY;
	public TimeMap map;

	void OnMouseUp() {
		//Debug.Log("Click");

		map.MoveSelectedUnitTo(tileX, tileY);
	}
}
