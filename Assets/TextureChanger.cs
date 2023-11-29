using MixedReality.Toolkit;
using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static Unity.VisualScripting.Member;
using static UnityEngine.Rendering.DebugUI.Table;

public class TextureChanger: MonoBehaviour
{  
    public GameObject cube;
    public Texture[] textures;

    public Renderer cubeRenderer;
 
    public int randomTextureIndex;
  
    public void Start()
    {
        
        StatefulInteractable statefulInteractable = gameObject.AddComponent<StatefulInteractable>();
        gameObject.AddComponent<UGUIInputAdapter>();
        statefulInteractable.OnClicked.AddListener(ChangeCubeTexture);
   
        cubeRenderer = cube.GetComponent<Renderer>();
        
    }

    public void ChangeCubeTexture()
    {
        randomTextureIndex = Random.Range(0, textures.Length);
        Debug.Log("clicked");
      
        if (cubeRenderer != null && textures.Length > 0 )
        {
            cubeRenderer.material.mainTexture = textures[randomTextureIndex];
            

        }
        else
        {
            Debug.LogError("Cube Renderer not found or textures array is empty!");
            
        }
        
        
    }
    
}







        

