using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSystem : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "EscapeLadder")
        {
            Debug.Log("Вы сбежали!");
        }
    }
}
