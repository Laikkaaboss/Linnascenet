using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Canvas quitMenu2;
    public Button startText; //play button
    public Button exitText; // Exit button
	// Use this for initialization
	void Start () {

        quitMenu = quitMenu.GetComponent<Canvas>();
        quitMenu2 = quitMenu2.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
        quitMenu2.enabled = false;

    }

    public void exitPress()
    {
        quitMenu.enabled = true;
        quitMenu2.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void noPress()
    {
        quitMenu.enabled = false;
        quitMenu2.enabled = false;
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
