using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTyper : MonoBehaviour
{

    public float letterPause = 0.2f;
    public AudioClip typeSound1;
    public AudioClip typeSound2;
	public Text teksti;
    public string message;
    Text textComp;

    // Use this for initialization
    void Start()
	{
		textComp = teksti;
        //textComp = GetComponent<Text>();
		//message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
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
    }
}