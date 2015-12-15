using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameoverMenu : MonoBehaviour {

    public Canvas quitMenu;
    public Button startText; //play button
    public Button exitText; // Exit button
                            // Use this for initialization
    void Start()
    {

        quitMenu = quitMenu.GetComponent<Canvas>();
 
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;


    }

    public void exitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void noPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void startLevel()
    {
        Application.LoadLevel(1);
    }

    public void exitGame()
    {
        Application.Quit();
    }

}

