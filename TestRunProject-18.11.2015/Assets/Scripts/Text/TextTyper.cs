﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTyper : MonoBehaviour
{

    public float letterPause = 0.2f;
    public AudioClip typeSound1;
    public AudioClip typeSound2;
	public Text teksti;
    public Text QuestText;
    public string questMessage;
    public string message;
    Text textComp;
    Text textQuest;

    // Use this for initialization
    void Start()
	{
      //  StartCoroutine(Waitti());
        textQuest = QuestText;
		textComp = teksti;
        //textComp = GetComponent<Text>();
        //message = textComp.text;
        textQuest.text = "";
        textComp.text = "";
        StartCoroutine(TypeText());
    }
    IEnumerator Waitti()
    {
        yield return new WaitForSeconds(2);
    }
    IEnumerator TypeText()
    {
		//Debug.Log (message);
		//word by word..
		int words = 0;
		int pointers = 0;
        foreach (char letter in message.ToCharArray())
        {

			if (letter.ToString() == " "){
				words++;
			}
			if (letter.ToString() == "."){
				pointers++;
			}
			else{
				pointers = 0;
			}
			if (pointers == 3){
                yield return new WaitForSeconds(5);
                textComp.text = "";
				words = 0;
			}
			else{
		//	Debug.Log (letter);
			if (words == 8){
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
        yield return new WaitForSeconds(3);
       
        yield return new WaitForSeconds(5);
        textComp.text = "";
        yield return new WaitForSeconds(1);
        QuestText.text += "QUEST: " + questMessage;
    }

}