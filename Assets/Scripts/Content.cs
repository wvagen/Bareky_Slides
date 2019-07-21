using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Content : MonoBehaviour
{
    public Transform rotatorAxe;

    void Update()
    {
        rotatorAxe.Rotate(-Vector3.forward * Time.deltaTime * 5);
    }

}
