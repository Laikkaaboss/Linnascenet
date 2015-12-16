using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TextTyoerScene1 : MonoBehaviour {

    public float letterPause = 0.2f;
    public AudioClip typeSound1;
    public AudioClip typeSound2;
    public Text teksti;
    public Text QuestText;
    public string questMessage;
    public string message;
    Text textComp;
    Text textQuest;
    private bool used;
    // Use this for initialization
    // Use this for initialization
    void Start()
    {
        used = false;
        textQuest = QuestText;
        textComp = teksti;
        //textComp = GetComponent<Text>();
        //message = textComp.text;
        textQuest.text = "";
        textComp.text = "";
       
    }
    void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "Player") {
			if (used == false) { 
				used = true;
				textQuest.text = "";
				textComp.text = "";
				StartCoroutine (TypeText ());
				QuestText.text += questMessage;
               
            }
		}
    }
    IEnumerator TypeText()
    {
        //Debug.Log (message);
        //word by word..
        int words = 0;
        int pointers = 0;
        foreach (char letter in message.ToCharArray())
        {

            if (letter.ToString() == " ")
            {
                words++;
            }
            if (letter.ToString() == ".")
            {
                pointers++;
            }
            else
            {
                pointers = 0;
            }
            if (pointers == 3)
            {
                yield return new WaitForSeconds(5);
                textComp.text = "";
                words = 0;
            }
            else
            {
                //	Debug.Log (letter);
                if (words == 8)
                {
                    words = 0;
                    textComp.text += "\n";
                }
                textComp.text += letter;
            }


            //  if (typeSound1 && typeSound2)
            //       SoundManager.instance.RandomizeSfx(typeSound1, typeSound2);
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
        yield return new WaitForSeconds(8);
        textComp.text = "";


    }
}