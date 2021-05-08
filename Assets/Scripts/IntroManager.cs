using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class IntroManager : MonoBehaviour
{
    public AudioClip bolTibetain;

    private AudioSource source;

    private void Awake()
    {
        source = this.GetComponent<AudioSource>();
    }

    public void Next()
    {
        source.clip = bolTibetain;
        source.loop = false;
        source.Play();
    }
}
