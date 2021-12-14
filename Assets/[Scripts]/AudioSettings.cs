using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string BackgroundPref = "BackgroundPref";
    private float backgroundFloat;
    public AudioSource bgAudio;

    void Awake()
    {
        ContinueSettings();
    }
    private void ContinueSettings()
    {
        backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
        bgAudio.volume = backgroundFloat;
    }


}
