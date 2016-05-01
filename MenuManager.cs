using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class MenuManager : MonoBehaviour {
    
    public Canvas quitMenu;
    public Canvas OptionsMenu;
    public Button startText;
    public Button exitText;
    public Button Options;
    public GameObject player;
    public GameObject menuCamera;
    public Text button;
    public GameObject menuPanel;

    public Transform canvas;
    public Transform Player;

    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        OptionsMenu = OptionsMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        Options = Options.GetComponent<Button>();
        quitMenu.enabled = false;
        OptionsMenu.enabled = false;
        player.SetActive(false);
     }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause();
        }
    }

    public void pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            Player.GetComponent<FirstPersonController>().enabled = false;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            Player.GetComponent<FirstPersonController>().enabled = true;
        }
    }

    public void OptionPress()
    {
        quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        OptionsMenu.enabled = true;
        player.SetActive(false);
        menuCamera.SetActive(true);
    }

    public void OptionSave()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        OptionsMenu.enabled = false;
        player.SetActive(false);
        menuCamera.SetActive(true);
    }

     public void ExitPress()
     {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        OptionsMenu.enabled = false;
        player.SetActive(false);
        menuCamera.SetActive(true);
    }

     public void NoPress()
     {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        OptionsMenu.enabled = false;
        player.SetActive(false);
        menuCamera.SetActive(true);
    }

     public void StartLevel()
     {
        //SceneManager.LoadScene(1);
        menuPanel.SetActive(false);
        player.SetActive(true);
        menuCamera.SetActive(false);
    }

     public void ExitGame()
     {
        Application.Quit();
     }
}
