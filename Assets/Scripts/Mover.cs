﻿using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3 (0.0f, 0.0f, speed);
    }
}