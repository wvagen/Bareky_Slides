using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresenationManager : MonoBehaviour
{
    public Animator myAnim;
    public GameObject[] Frames;
    public Text counter;

    int step = 0;
    void Update()
    {
        GetMouseInput();
        if (step == 0 || step ==25) counter.transform.parent.gameObject.SetActive(false);
        else
        {
            counter.transform.parent.gameObject.SetActive(true);
            counter.text = (step + 1).ToString();

        }
    }


    void GetMouseInput()
    {
        if (Input.GetMouseButtonDown(0) && step <26)
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
