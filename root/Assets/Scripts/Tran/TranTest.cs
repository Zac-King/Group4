using UnityEngine;
using System.Collections;

public class TranTest : MonoBehaviour {

	// Use this for initialization

    public AudioClip sound;
    public AudioClip secondsound;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.U))
            AudioManager.instance.PlayAudio(sound);

        if (Input.GetKeyDown(KeyCode.K))
            AudioManager.instance.PlayAudio(secondsound);
	
	}
}
