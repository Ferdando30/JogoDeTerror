using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pages : MonoBehaviour
{
    public GameObject PauseImage;
    public Button UnpauseButn;
    public Button MainMenuBtn;
    public Button OptionsBtn;
    public Button PagesBtn;
    public Pause PauseScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PagesBtn.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseScript.paused == true)
        {
            PagesBtn.gameObject.SetActive(true);
        }
        else
        {
            PagesBtn.gameObject.SetActive(false);
        }
    }

    public void PagesFunction()
    {
        PauseImage.SetActive(false);
        UnpauseButn.gameObject.SetActive(false);
        MainMenuBtn.gameObject.SetActive(false);
        OptionsBtn.gameObject.SetActive(false);
        PagesBtn.gameObject.SetActive(false);
    }
}
