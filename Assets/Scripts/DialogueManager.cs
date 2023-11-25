using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using UnityEngine.Playables;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI speakerName, dialogue, navButtonText;
    public Image speakerSprite;

    private int currentIndex;
    private Conversation currentConv;
    public static DialogueManager instance;
    public Animator anim;
    public bool hasEnd;
    //private CamSwitcher camSwitcher;
    //private DialogueTrigger trigger;


    [SerializeField] public float typingSpeed = 0.05f;
    private Coroutine displayLineCoroutine;
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            anim = GetComponent<Animator>();
            
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public static void StartConversation(Conversation conv)
    {
        //initialize dialoguebox
        instance.anim.SetBool("isOpen", true);
        instance.currentIndex = 0;
        instance.currentConv = conv;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        instance.navButtonText.text = ">";
        //instance.camSwitcher = camSwitcher;

        //show conversation
        instance.ReadNext();
    }

    public void ReadNext()
    {

        //to close the conversation when the index reaches its length
        if (currentIndex > currentConv.GetLength())
        {
            instance.anim.SetBool("isOpen", false);
            instance.hasEnd = true;
            //camSwitcher.ShowOverheadView();
            return;
        }

        speakerName.text = currentConv.GetLineByIndex(currentIndex).speaker.GetName();
        //dialogue.text = currentConv.GetLineByIndex(currentIndex).dialogue;
        if(displayLineCoroutine != null)
        {
            StopCoroutine(displayLineCoroutine);
        }
        displayLineCoroutine = StartCoroutine(showText(currentConv.GetLineByIndex(currentIndex).dialogue));
        speakerSprite.sprite = currentConv.GetLineByIndex(currentIndex).speaker.GetSprite();
        currentIndex++;


    }
    /// <summary>
    /// Exit the conversation
    /// </summary>
    public static void EndConversation()
    {
        instance.anim.SetBool("isOpen", false);
        //Cursor.visible = false;
    }

    private IEnumerator showText(string line)
    {
        //empty the dialogue text
        dialogue.text = "";

        //display each letter one at a time
        foreach (char letter in line.ToCharArray())
        {
            if (Input.GetMouseButtonDown(0))
            {
                dialogue.text = line;
                yield break;
            }
            dialogue.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
