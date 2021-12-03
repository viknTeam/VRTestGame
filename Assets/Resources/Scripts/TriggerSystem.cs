using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSystem : MonoBehaviour
{
    private TimeSystem timeSystem;
    public Text WinEndText;
    public Animator TextAnimator;
    private void Start()
    {
        timeSystem = GetComponent<TimeSystem>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "EscapeLadder")
        {
            WinEndText.text = "Вы сбежали";
            TextAnimator.Play("WinEndAnimTextAnim");
            Debug.Log("Вы сбежали");
            timeSystem.StopCoroutine("SecondsChange");
        }
        
    }
}
