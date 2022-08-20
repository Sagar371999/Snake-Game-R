/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudioManager : MonoBehaviour
{
    public static MenuAudioManager Iinstance;

    public AudioClip StartTheam;
    // Start is called before the first frame update
    void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if (Iinstance == null)
        {
            Iinstance = this;
        }
    }

    public void Play_StartTheme()
    {
        AudioSource.PlayClipAtPoint(StartTheam, transform.position);
    }
}*/