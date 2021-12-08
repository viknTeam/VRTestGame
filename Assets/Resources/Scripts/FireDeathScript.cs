using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FireDeathScript : MonoBehaviour
{
    public Text WinEndText;
    public Animator TextAnimator;
    public TimeSystem timeSystem;
    private GameObject TeleportingSystem;
    private TriggerSystem triggerSystem;

    private void Start()
    {
        TeleportingSystem = GameObject.FindGameObjectWithTag("TeleportSystem");
        triggerSystem = GameObject.FindGameObjectWithTag("EscapeLadder").GetComponent<TriggerSystem>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TeleportingSystem.SetActive(false);
            WinEndText.text = "Вы сгорели";
            TextAnimator.Play("WinEndTextAnim");
            timeSystem.StopTimer();
            StartCoroutine(triggerSystem.ReturnToStartScreen());
        }
    }
}
