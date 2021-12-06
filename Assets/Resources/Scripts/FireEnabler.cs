using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnabler : MonoBehaviour
{
    public ParticleSystem ParticleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        ParticleSystem.gameObject.SetActive(true);
    }
}
