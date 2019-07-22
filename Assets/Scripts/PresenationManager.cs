using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresenationManager : MonoBehaviour
{
    public Animator myAnim;
    public GameObject[] Frames;

    int step = 0;
    void Update()
    {
        GetMouseInput();
    }


    void GetMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DisableAllFrames();
            step++;
        }
        else if (Input.GetMouseButtonDown(1) && step > 0)
        {
            DisableAllFrames();
            step--;
        }
        myAnim.SetInteger("Step", step);
    }

    void DisableAllFrames()
    {
        foreach (GameObject f in Frames) f.SetActive(false);
    }

}
