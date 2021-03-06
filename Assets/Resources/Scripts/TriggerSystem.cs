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
            WinEndText.text = "?? ???????";
            TextAnimator.Play("WinEndTextAnim");
            timeSystem.StopTimer();
            StartCoroutine(ReturnToStartScreen());
        }
        if (gameObject.name == "MainMenuCube")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    public IEnumerator ReturnToStartScreen()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainMenu");
    }
}
