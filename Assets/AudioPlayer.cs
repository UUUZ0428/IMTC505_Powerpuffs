using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    //public AudioSource m_MyAudioSource;
    bool m_Play = true;
    public AudioClip music;
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        source.clip = music;
        //music = Resources.Load<AudioClip>("Assets/playMusic/okanagan_song.mp3");
        
    }

    // Update is called once per frame
    public void playMusic()
    {
        if(!m_Play){
            source.Play();
            m_Play = true;
        } else{
            source.Stop();
            m_Play = false;
        }
        
        
    }
}
