using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioMixerGroup audioMixerGroup;

    void Start() {
        audioSource.outputAudioMixerGroup = audioMixerGroup;
    }
}
