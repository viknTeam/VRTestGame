using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnabler : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
    public GameObject FireCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FireCollider.SetActive(true);
            ParticleSystem.Play();
        }
    }
}
