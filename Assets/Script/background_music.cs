using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_music : MonoBehaviour {
    public AudioClip[] music = new AudioClip[3];
    private AudioSource music_clip;
    public GameObject fps;
    private bool bstop;
    // Use this for initialization
    void Start () {
        music_clip = GetComponent<AudioSource>();
        
   
    }
    public void music_stop(bool tmp)
    {
        bstop = tmp;
    }
    
    float second = 0;
	// Update is called once per frame
	void Update () {
        second += Time.deltaTime;
        if (second < 30 && !music_clip.isPlaying)
        {
            Debug.Log(second);
            music_clip.clip = music[0];
            music_clip.Play();
            music_clip.volume = 0.1f;
        }
        else if(second < 60 && !music_clip.isPlaying)
        {
            music_clip.clip = music[1];
            music_clip.Play();
        }
	}
}
