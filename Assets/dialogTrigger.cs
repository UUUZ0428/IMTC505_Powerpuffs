using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogTrigger : MonoBehaviour
{
    public Conversation conv;
    // Start is called before the first frame update
    void Start()
    {
        DialogueManager.StartConversation(conv);
        
    }


}
