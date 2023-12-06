using MixedReality.Toolkit;
using MixedReality.Toolkit.SpatialManipulation;
using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AudioPlayer : MonoBehaviour
{
    //public AudioSource m_MyAudioSource;
    bool m_Play = true;
    public AudioClip music;
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = music;
        // Add StatefulInteractable component to the existing GameObject
        StatefulInteractable statefulInteractable = gameObject.AddComponent<StatefulInteractable>();
        //add the UGUIInputAdapter to the gameobject
         gameObject.AddComponent<UGUIInputAdapter>();
        //onclick call the method 
        statefulInteractable.OnClicked.AddListener(playMusic);
        

    }

    // Update is called once per frame
    public void playMusic()
    {
        m_Play = !m_Play;// toggle state of music 
        if (!m_Play)
        {
            source.Play(); //start music       
        }
        else
        {
            source.Stop();//stop music 

        }
    }
}