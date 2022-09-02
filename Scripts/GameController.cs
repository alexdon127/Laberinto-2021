using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private new AudioSource audio;
    public AudioClip clipLlave; 

    void Start()
    {
       audio = GetComponent<AudioSource>();
    }

    /*void Update()
    {
        
    }*/

    public void SonarDiamante()
    {
        audio.Play();
    }

    public void SonarLlave()
    {
        audio.clip = clipLlave;
        audio.Play();
    }
}


