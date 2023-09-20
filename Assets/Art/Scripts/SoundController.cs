using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundController : MonoBehaviour
{
    public AudioClip[] clip1;

    private AudioSource audio;


    public void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void PlaySoundCoin()
    {
        audio.clip = clip1[0];
        audio.Play();
    }

    public void PlaySoundHurt()
    {
        audio.clip = clip1[1];
        audio.Play();
    }
    public void PlaySoundOpenDoor()
    {
        audio.clip = clip1[2];
        audio.Play();
    }
    public void PlaySoundGameOver()
    {
        audio.clip = clip1[3];
        audio.Play();
    }
}
