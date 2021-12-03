using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSystem : MonoBehaviour
{

    [Range(00,200)]
    public float SecondsLeftRange;
    public static float SecondsLeft;

    public Text SecondsText;

    private void Start()
    {
        SecondsLeft = SecondsLeftRange;
        SecondsText.text = SecondsLeft.ToString();
        StartCoroutine(SecondsChange());

    }
    void Update()
    {
    }
    public IEnumerator SecondsChange()
    {
        while(SecondsLeft > 0)
        {
            SecondsLeft -= Time.deltaTime;
            UpdateTimerText();
            yield return null;
        }
        if (SecondsLeft == 0)
        {

        }
    }
    private void UpdateTimerText()
    {
        SecondsText.text = SecondsLeft.ToString();
    }
}
