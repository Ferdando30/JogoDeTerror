using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject PauseIg;
    public GameObject PauseBG;
    public GameObject ControlsIg;
    public Button UnpauseBtn;
    public Button MainMenu;
    public Button Options;
    public Button Back;
    public bool paused;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PauseIg.SetActive(false);
        PauseBG.SetActive(false);
        ControlsIg.SetActive(false);
        UnpauseBtn.gameObject.SetActive(false);
        MainMenu.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        Back.gameObject.SetActive(false);
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (paused == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                PauseIg.SetActive(true);
                PauseBG.SetActive(true);
                UnpauseBtn.gameObject.SetActive(true);
                MainMenu.gameObject.SetActive(true);
                Options.gameObject.SetActive(true);
                paused = true;
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                PauseIg.SetActive(false);
                PauseBG.SetActive(false);
                ControlsIg.SetActive(false);
                UnpauseBtn.gameObject.SetActive(false);
                MainMenu.gameObject.SetActive(false);
                Options.gameObject.SetActive(false);
                paused = false;
                Time.timeScale = 1;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }


        }
    }

    public void UnpauseFunction()
    {
        PauseIg.SetActive(false);
        PauseBG.SetActive(false);
        UnpauseBtn.gameObject.SetActive(false);
        MainMenu.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        paused = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void MainMenuBtn()
    {
        SceneManager.LoadScene("Menu");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1;
    }

    public void ControlsBtn()
    {
        PauseIg.SetActive(false);
        UnpauseBtn.gameObject.SetActive(false);
        MainMenu.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        ControlsIg.SetActive(true);
        Back.gameObject.SetActive(true);
    }
    
    public void BackBtn()
    {
        PauseIg.SetActive(true);
        UnpauseBtn.gameObject.SetActive(true);
        MainMenu.gameObject.SetActive(true);
        Options.gameObject.SetActive(true);
        ControlsIg.SetActive(false);
        Back.gameObject.SetActive(false);
    }
}
