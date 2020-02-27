using UnityEngine.Audio;
using System;
using UnityEngine;

public class audiomanager : MonoBehaviour {

    public Sound[] sound; // sounds array
    public static audiomanager instance;
	// Use this for initialization
	void Awake () {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        
        foreach(Sound s in sound)  // looking for sound in sound array
        {
          s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            // s.source.loop = s.loop;
        }
		
	}

    /*void Start()
    {
        play("Theme");
    }*/
	
    public void play (string name) // function to call sound to play
    {
        Sound s = Array.Find(sound, sound => sound.name == name);
        if(s == null)
        {
            Debug.LogWarning("Sound" + name + "not Found!");
            return;
        }
        s.source.Play();
    }
}
