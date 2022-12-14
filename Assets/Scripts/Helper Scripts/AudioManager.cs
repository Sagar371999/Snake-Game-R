using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioClip pickUp_Sound;
    public AudioClip dead_Sound;
    public AudioClip Power_Sound;


    void Awake()
    {
        MakeInstance();
    }

    // Update is called once per frame
    void MakeInstance()
    {
        if(instance==null)
        {
            instance = this;
        }
    }

    public void play_PickUpSound()
    {
        AudioSource.PlayClipAtPoint(pickUp_Sound, transform.position);
    }
    public void play_DeadSound()
    {
        AudioSource.PlayClipAtPoint(dead_Sound, transform.position);
    }
    public void play_PowerSound()
    {
        AudioSource.PlayClipAtPoint(Power_Sound, transform.position);
    }
    
}
