using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeSystem : MonoBehaviour
{

    [Range(00, 200)]
    public float SecondsLeftRange;
    public static float SecondsLeft;

    public Text SecondsText;
    private void Start()
    {
        SecondsLeft = SecondsLeftRange;
        SecondsText.text = SecondsLeft.ToString();
        StartCoroutine(SecondsChange());
    }
    public IEnumerator SecondsChange()
    {
        while (SecondsLeft > 0)
        {
            SecondsLeft -= Time.deltaTime;
            UpdateTimerText();
            StopCoroutine("SecondsChange");
            yield return null;
        }

    }
    private void UpdateTimerText()
    {
        SecondsText.text = SecondsLeft.ToString("0");
    }
    public void StopTimer()
    {
        StopAllCoroutines();
    }
}
