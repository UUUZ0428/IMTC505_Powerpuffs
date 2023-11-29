using MixedReality.Toolkit;
using MixedReality.Toolkit.SpatialManipulation;
using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Testclick : MonoBehaviour
{
    //public AudioSource m_MyAudioSource;
   

    // Start is called before the first frame update
    void Start()
    {
    

        StatefulInteractable statefulInteractable = gameObject.AddComponent<StatefulInteractable>();
        gameObject.AddComponent<UGUIInputAdapter>();
        statefulInteractable.OnClicked.AddListener(testing);


    }

    // Update is called once per frame
    public void testing()
    {
        Debug.Log("click");
    }
}
