using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pages : MonoBehaviour
{
    public GameObject PauseImage;
    public GameObject PagesImg;
    public Button UnpauseButn;
    public Button MainMenuBtn;
    public Button OptionsBtn;
    public Button PagesBtn;
    public Pause PauseScript;
    public Button BackBtn;

    public Button PageOneBtn;
    public Button PageTwoBtn;
    public Button PageThreeBtn;
    public Button PageFourBtn;
    public Button PageFiveBtn;
    public Button PageSixBtn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PagesBtn.gameObject.SetActive(false);
        PagesImg.SetActive(false);
        PageOneBtn.gameObject.SetActive(false);
        PageTwoBtn.gameObject.SetActive(false);
        PageThreeBtn.gameObject.SetActive(false);
        PageFourBtn.gameObject.SetActive(false);
        PageFiveBtn.gameObject.SetActive(false);
        PageSixBtn.gameObject.SetActive(false);
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
            PagesImg.SetActive(false);
            PagesBtn.gameObject.SetActive(false);
            PageOneBtn.gameObject.SetActive(false);
            PageTwoBtn.gameObject.SetActive(false);
            PageThreeBtn.gameObject.SetActive(false);
            PageFourBtn.gameObject.SetActive(false);
            PageFiveBtn.gameObject.SetActive(false);
            PageSixBtn.gameObject.SetActive(false);
        }
    }

    public void PagesFunction()
    {
        PauseImage.SetActive(false);
        UnpauseButn.gameObject.SetActive(false);
        MainMenuBtn.gameObject.SetActive(false);
        OptionsBtn.gameObject.SetActive(false);
        PagesBtn.gameObject.SetActive(false);
        PagesImg.SetActive(true);
        BackBtn.gameObject.SetActive(true);

        PageOneBtn.gameObject.SetActive(true);
        PageTwoBtn.gameObject.SetActive(true);
        PageThreeBtn.gameObject.SetActive(true);
        PageFourBtn.gameObject.SetActive(true);
       PageFiveBtn.gameObject.SetActive(true);
        PageSixBtn.gameObject.SetActive(true);
    }
    
    public void BackFunction()
    {
        PauseImage.SetActive(true);
        UnpauseButn.gameObject.SetActive(true);
        MainMenuBtn.gameObject.SetActive(true);
        OptionsBtn.gameObject.SetActive(true);
        PagesBtn.gameObject.SetActive(true);
        PagesImg.SetActive(false);
        BackBtn.gameObject.SetActive(false);

        PageOneBtn.gameObject.SetActive(false);
        PageTwoBtn.gameObject.SetActive(false);
        PageThreeBtn.gameObject.SetActive(false);
        PageFourBtn.gameObject.SetActive(false);
        PageFiveBtn.gameObject.SetActive(false);
        PageSixBtn.gameObject.SetActive(false);
    }
}
