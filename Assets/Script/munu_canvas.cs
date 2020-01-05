using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class munu_canvas : MonoBehaviour {
    public AudioClip[] music = new AudioClip[3];
    private AudioSource music_clip;
    // Use this for initialization
    void Start () {
        music_clip = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!music_clip.isPlaying)
        {
            music_clip.clip = music[0];
            music_clip.Play();
        }
	}
}
