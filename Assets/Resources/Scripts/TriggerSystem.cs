using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerSystem : MonoBehaviour
{
    public Text WinEndText;
    public Animator TextAnimator;
    public TimeSystem timeSystem;
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "EscapeLadder")
        {
            WinEndText.text = "�� �������";
            TextAnimator.Play("WinEndTextAnim");
            timeSystem.StopTimer();
            StartCoroutine(ReturnToStartScreen());
            
        }
        if (gameObject.tag == "Fire")
        {
            WinEndText.text = "������� � ���";
            TextAnimator.Play("WinEndTextAnim");
            timeSystem.StopTimer();
            ReturnToStartScreen();
        }
    }
    private IEnumerator ReturnToStartScreen()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainMenu");
    }
}
