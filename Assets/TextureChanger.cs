using MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TextureChanger: MonoBehaviour
{
    public Texture newTexture; // Drag and drop the new texture in the inspector
    public Renderer rend;
 

    void Start()
    {
        StatefulInteractable statefulInteractable = gameObject.AddComponent<StatefulInteractable>();
        statefulInteractable.OnClicked.AddListener(ChangeObjectTextureOnClick);
        if (rend == null)
        {
            rend = GetComponent<Renderer>();
        }
        if (rend == null)
        {
            Debug.LogError("Renderer component not found!");
        } 
                
    }

    public void ChangeObjectTextureOnClick()
    {
        Debug.Log("Clicked");
        if (rend != null && newTexture != null)
        {
            rend.material.mainTexture = newTexture;
        }
        else
        {
            Debug.LogError("Renderer or new texture is not assigned!");
        }
    }
}
