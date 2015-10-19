﻿using UnityEngine;
using System.Collections;

public class CockPit : MonoBehaviour {

    private float rotAngle = 0f;
    public float rotSpeed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        rotAngle += rotSpeed * Time.deltaTime;
        if (rotAngle > 360) rotAngle -= 360;
        transform.rotation = Quaternion.Euler(0, 0, rotAngle);
	}
}
