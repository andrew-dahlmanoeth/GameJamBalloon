using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public AudioMixer mixer;
    
    public void SetVolume(float Volume)
    {
        mixer.SetFloat("MasterVol", Volume);
    }
}
