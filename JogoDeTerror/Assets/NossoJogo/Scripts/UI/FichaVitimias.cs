using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FichaVitimias : MonoBehaviour
{
    public GameObject FichaImage; 
    public GameObject VitimaImage; //vou remover quando a imagem oficial da ficha estiver pronta
    public TextMeshProUGUI PressUI;
    public TextMeshProUGUI text1; //vou remover quando a imagem oficial da ficha estiver pronta
    public TextMeshProUGUI text2; //vou remover quando a imagem oficial da ficha estiver pronta
    public TextMeshProUGUI text3; //vou remover quando a imagem oficial da ficha estiver pronta
    public Button StartBtn;
    public Button OpenFicha;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FichaImage.SetActive(false);
        VitimaImage.SetActive(false);
        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
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
            //PressUI.enabled = true;
            if(Input.GetKey(KeyCode.E))
            {
                FichaImage.SetActive(true);
                VitimaImage.SetActive(true);
                text1.enabled = true;
                text2.enabled = true;
                text3.enabled = true;
                PressUI.enabled = false;
                StartBtn.gameObject.SetActive(true);
                OpenFicha.gameObject.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

             
            }
        }
    }

    void OnTriggerExit(Collider hit)
    {
        PressUI.enabled = false;
    }
}
