using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Content : MonoBehaviour
{
    public Transform rotatorAxe;
    public float rotSpeed = 5f;

    void Start()
    {
        if (rotatorAxe == null) rotatorAxe = transform;
    }

    void Update()
    {
        rotatorAxe.Rotate(-Vector3.forward * Time.deltaTime * rotSpeed);
    }

}
