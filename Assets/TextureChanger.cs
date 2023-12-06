using MixedReality.Toolkit;
using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using static Unity.VisualScripting.Member;
using static UnityEngine.Rendering.DebugUI.Table;

public class TextureChanger: MonoBehaviour
{  
    public GameObject cube;
    // Renderer component of the cube and an index to track the current texture
    public Texture[] textures;
    // Renderer component of the cube and an index to track the current texture
    public Renderer cubeRenderer;
 
    public int randomTextureIndex;

    // Start is called before the first frame update
    public void Start()
    {
        // Add StatefulInteractable component to enable interaction with this GameObject
        StatefulInteractable statefulInteractable = gameObject.AddComponent<StatefulInteractable>();
        // Add UGUIInputAdapter for handling input
        gameObject.AddComponent<UGUIInputAdapter>();
        // Add a listener to detect the OnClicked event and trigger the ChangeCubeTexture method

        statefulInteractable.OnClicked.AddListener(ChangeCubeTexture);
        // Get the Renderer component of the cube GameObject
        cubeRenderer = cube.GetComponent<Renderer>();
        
    }
    // Method to change the texture of the cube
    public void ChangeCubeTexture()
    {
        // Generate a random index within the range of the textures array
        randomTextureIndex = Random.Range(0, textures.Length);
        Debug.Log("clicked");
      
        if (cubeRenderer != null && textures.Length > 0 )
        {
            // Change the main texture of the cube to the randomly chosen texture
            cubeRenderer.material.mainTexture = textures[randomTextureIndex];
            

        }
        else
        {// Log an error if the cube Renderer is not found or the textures array is empty
            Debug.LogError("Cube Renderer not found or textures array is empty!");
            
        }
        
        
    }
    
}







        

