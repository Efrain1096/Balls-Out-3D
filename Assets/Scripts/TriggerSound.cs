using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioSource playSound;




    public void OnTriggerEnter(Collider other)
    {
        playSound.Play();
    }

}
