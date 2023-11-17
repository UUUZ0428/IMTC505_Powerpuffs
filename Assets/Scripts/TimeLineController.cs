using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;
using UnityEngine.UI;

public class TimeLineController : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public GameObject dialoguePanel; // Your dialogue UI panel
    //public Text dialogueText; // Text component to show dialogue
    //public Button nextButton; // Button to proceed dialogue
    public Conversation conv;

    // Start is called before the first frame update
    void Start()
    {
        //hide dialogue panel initially
        //dialoguePanel.SetActive(false); 
        
    }

    
    void Update(){
    
        if(DialogueManager.instance.hasEnd){
            playableDirector.Play();
        } 
        
    }
        
    // called by the Signal Receiver
    public void TriggerDialogueFromSignal()
    {
        if (playableDirector != null){
            playableDirector.Pause(); // Pause the Timeline
            DialogueManager.StartConversation(conv);
            Debug.Log("play paused");

        } else{
            Debug.LogError("PlayableDirector not assigned");
        }

        //dialoguePanel.SetActive(true); 
    }

    public void EndDialogue(){
        DialogueManager.EndConversation();
        //dialoguePanel.SetActive(false); 
        playableDirector.Play(); // Play the Timeline
        Debug.Log("end conv");

    }

}
