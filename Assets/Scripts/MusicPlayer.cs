using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
{
    private AudioSource source;

    private void Awake()
    {
        
        source = GetComponent<AudioSource>();
    }

    private void Start()
    {
        DontDestroyOnLoad(this);
        source.Play();
    }
}
