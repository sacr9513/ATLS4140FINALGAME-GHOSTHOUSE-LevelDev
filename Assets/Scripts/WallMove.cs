﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}
