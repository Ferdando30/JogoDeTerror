using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FichaVitimias : MonoBehaviour
{
    public GameObject FichaImage; 
    
    public TextMeshProUGUI PressUI;
    
    public Button StartBtn;
    public Button OpenFicha;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FichaImage.SetActive(false);
        
        PressUI.enabled = false;
        StartBtn.gameObject.SetActive(false);
        OpenFicha.gameObject.SetActive(false);

        
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
}
