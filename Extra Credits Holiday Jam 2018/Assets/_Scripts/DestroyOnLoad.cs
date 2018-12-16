﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnLoad : MonoBehaviour {

	public float TimeUntilDestruction = 4f;
	void Start () {
    StartCoroutine("EndObject");
		Destroy(gameObject, TimeUntilDestruction);
	}
}
