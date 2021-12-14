using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeSystem : MonoBehaviour
{

    [Range(00, 200)]
    public float SecondsLeftRange;
    public static float SecondsLeft;

    public Text SecondsText;
    public TriggerSystem TriggerSystem;
    private void Start()
    {
        SecondsLeft = SecondsLeftRange;
        SecondsText.text = SecondsLeft.ToString();
        StartCoroutine(SecondsChange());
    }
    public IEnumerator SecondsChange()
    {
        while (SecondsLeft >= 0)
        {
            SecondsLeft -= Time.deltaTime;
            UpdateTimerText();
            yield return null;
        }
        TriggerSystem.WinEndText.text = "Вы сбежали";
        TriggerSystem.TextAnimator.Play("WinEndTextAnim");
        StopTimer();
        TriggerSystem.StartCoroutine("ReturnToStartScreen");
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
