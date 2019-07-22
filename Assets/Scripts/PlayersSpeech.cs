using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersSpeech : MonoBehaviour
{
    public string[] quotes;
    public Text speech;

    bool isTalking = false;
    void Update()
    {
        if (!isTalking) StartCoroutine(changeSpeech());
    }

    IEnumerator changeSpeech()
    {
        isTalking = true;
        speech.text = quotes[Random.Range(0, quotes.Length)];
        yield return new WaitForSeconds(Random.Range(3f, 5f));
        isTalking = false;

    }

}
