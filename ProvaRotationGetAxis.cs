﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProvaRotationGetAxis : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, Input.GetAxis("Horizontal") * speed, 0.0f);
    }
}
