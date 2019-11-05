using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Done_RandomRotator : MonoBehaviour 
{
    private Rigidbody rb;

    public float tumble;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}