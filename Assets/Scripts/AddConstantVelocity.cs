using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 forceVector;


    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += forceVector; // Add force every update to simulate inertia?
    }
}
