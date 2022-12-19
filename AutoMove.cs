using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;
using Random=UnityEngine.Random;

public class AutoMove : MonoBehaviour
{
    public float speed;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        position = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += position * Time.deltaTime * speed;
    }
}
