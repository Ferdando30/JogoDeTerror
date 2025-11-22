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
   
    public GameObject PageOneImg;
    public GameObject PageTwoImg;
    public GameObject PageThreeImg;
    public GameObject PageFourImg;
    public GameObject PageFiveImg;
    public GameObject PageSixImg;

    public GameObject PageOneObj;
    public GameObject PageTwoObj;
    public GameObject PageThreeObj;
    public GameObject PageFourObj;
    public GameObject PageFiveObj;
    public GameObject PageSixObj;

    public GameObject PageOneTxt;
    public GameObject PageTwoTxt;
    public GameObject PageThreeTxt;
    public GameObject PageFourTxt;
    public GameObject PageFiveTxt;
    public GameObject PageSixTxt;
    public Button BackTxt;


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
        PageOneImg.SetActive(false);
        PageTwoImg.SetActive(false);
        PageThreeImg.SetActive(false);
        PageFourImg.SetActive(false);
        PageFiveImg.SetActive(false);
        PageSixImg.SetActive(false);

        PageOneTxt.SetActive(false);
        PageTwoTxt.SetActive(false);
        PageThreeTxt.SetActive(false);
        PageFourTxt.SetActive(false);
        PageFiveTxt.SetActive(false);
        PageSixTxt.SetActive(false);
        BackTxt.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (PauseScript.paused == true)
        {
            PagesBtn.gameObject.SetActive(true);
            if (PageOneObj == null)
            {
                PageOneImg.SetActive(true);
                PageOneBtn.gameObject.SetActive(true);
            }
            if (PageTwoObj == null)
            {
                PageTwoImg.SetActive(true);
                PageTwoBtn.gameObject.SetActive(true);
            }
            if (PageThreeObj == null)
            {
                PageThreeImg.SetActive(true);
                PageThreeBtn.gameObject.SetActive(true);
            }
            if (PageFourObj == null)
            {
                PageFourImg.SetActive(true);
                PageFourBtn.gameObject.SetActive(true);
            }
            if (PageFiveObj == null)
            {
                PageFiveImg.SetActive(true);
                PageFiveBtn.gameObject.SetActive(true);
            }
            if (PageSixObj == null)
            {
                PageSixImg.SetActive(true);
                PageSixBtn.gameObject.SetActive(true);
            }
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
            PageOneImg.SetActive(false);
            PageTwoImg.SetActive(false);
            PageThreeImg.SetActive(false);
            PageFourImg.SetActive(false);
            PageFiveImg.SetActive(false);
            PageSixImg.SetActive(false);
            PageOneTxt.SetActive(false);
            PageTwoTxt.SetActive(false);
            PageThreeTxt.SetActive(false);
            PageFourTxt.SetActive(false);
            PageFiveTxt.SetActive(false);
            PageSixTxt.SetActive(false);
            BackTxt.gameObject.SetActive(false);
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

    public void BackTxtFunction()
    {
        PageOneTxt.SetActive(false);
        PageTwoTxt.SetActive(false);
        PageThreeTxt.SetActive(false);
        PageFourTxt.SetActive(false);
        PageFiveTxt.SetActive(false);
        PageSixTxt.SetActive(false);
        BackTxt.gameObject.SetActive(false);
    }

    public void PageOneFunction()
    {
        PageOneTxt.SetActive(true);
        BackTxt.gameObject.SetActive(true);
    }

    public void PageTwoFunction()
    {
        PageTwoTxt.SetActive(true);
        BackTxt.gameObject.SetActive(true);
    }

    public void PageThreeFunction()
    {
        PageThreeTxt.SetActive(true);
        BackTxt.gameObject.SetActive(true);
    }

    public void PageFourFunction()
    {
        PageFourTxt.SetActive(true);
        BackTxt.gameObject.SetActive(true);
    }

    public void PageFiveFunction()
    {
        PageFiveTxt.SetActive(true);
        BackTxt.gameObject.SetActive(true);
    }

    public void PageSixFunction()
    {
        PageSixTxt.SetActive(true);
        BackTxt.gameObject.SetActive(true);
    }
}
