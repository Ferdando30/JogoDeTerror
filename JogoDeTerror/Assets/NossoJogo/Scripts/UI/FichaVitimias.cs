using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FichaVitimias : MonoBehaviour
{
    public GameObject FichaImage; 
    
    public TextMeshProUGUI PressUI;
    
    public Button StartBtn;
    public Button OpenFicha;
    public GameObject Relatorio;
    public GameObject X1;
    public GameObject X2;
    public GameObject X3;
    public GameObject X4;
    public GameObject XExit;
    public Button X1Btn;
    public Button X2Btn;
    public Button X3Btn;
    public Button X4Btn;
    public Button XExitBtn;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FichaImage.SetActive(false);
        Relatorio.SetActive(false);
        X1.SetActive(false);
        X2.SetActive(false);
        X3.SetActive(false);
        X4.SetActive(false);
        XExit.SetActive(false);
        
        PressUI.enabled = false;
        StartBtn.gameObject.SetActive(false);
        OpenFicha.gameObject.SetActive(false);
        X1Btn.gameObject.SetActive(false);
        X2Btn.gameObject.SetActive(false);
        X3Btn.gameObject.SetActive(false);
        X4Btn.gameObject.SetActive(false);
        XExitBtn.gameObject.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider hit)
    {
        if(hit.tag == "Player")
        {
            PressUI.enabled = true;
            if(Input.GetKey(KeyCode.E))
            {
                FichaImage.SetActive(true);
                
                PressUI.enabled = false;
                StartBtn.gameObject.SetActive(true);
                OpenFicha.gameObject.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0;

            }
        }
    }

    void OnTriggerExit(Collider hit)
    {
        PressUI.enabled = false;
    }

    public void FichaFunction()
    {
        Relatorio.SetActive(true);
        StartBtn.gameObject.SetActive(false);
        FichaImage.SetActive(false);
        XExit.SetActive(true);

        X1Btn.gameObject.SetActive(true);
        X2Btn.gameObject.SetActive(true);
        X3Btn.gameObject.SetActive(true);
        X4Btn.gameObject.SetActive(true);
        XExitBtn.gameObject.SetActive(true);
    }

    public void XExitFunction()
    {
        FichaImage.SetActive(false);
        Relatorio.SetActive(false);
        X1.SetActive(false);
        X2.SetActive(false);
        X3.SetActive(false);
        X4.SetActive(false);
        XExit.SetActive(false);

        PressUI.enabled = false;
        StartBtn.gameObject.SetActive(false);
        OpenFicha.gameObject.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }

    public void X1Function()
    {
        X1.SetActive(true);
    }
    public void X2Function()
    {
        X2.SetActive(true);
    }
    public void X3Function()
    {
        X3.SetActive(true);
    }
    public void X4Function()
    {
        X4.SetActive(true);
    }
}
