﻿using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

	public float rotationPerSecond = 0.1f;
	public bool ________________________;
	public int levelShown = 0;

	void Update() {
	
		int currLevel = Mathf.FloorToInt (Hero.S.shieldLevel);
		if (levelShown != currLevel) {

			levelShown = currLevel;
			Material mat = this.GetComponent<Renderer>().material;
			mat.mainTextureOffset = new Vector2 (0.2f * levelShown, 0);

		}
		float rZ = (rotationPerSecond * Time.time * 360) % 360f;
		transform.rotation = Quaternion.Euler (0, 0, rZ);
	}
}
