using UnityEngine;
using System.Collections;

public class AudioManager : Singleton<AudioManager>
{
    
    public AudioSource aSource;
	public void PlayAudio(AudioClip audio)
    {
        //aSource.PlayOneShot(audio);
        aSource.clip = audio;
        aSource.Play();
    }

   
}
