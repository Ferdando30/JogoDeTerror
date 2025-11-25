using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Rendering.HighDefinition.ScalableSettingLevelParameter;

public class MainMenu : MonoBehaviour
{
    public GameObject ControlsIg;
    public Button PlayBtn;
    public Button QuitBtn;
    public Button Options;
    public Button BackBtn;
    public GameObject telaInicialImg;
    public AudioSource SomInicio;
    public AudioClip clipe;

    private void Start()
    {
        ControlsIg.SetActive(false);
        telaInicialImg.SetActive(true);
        PlayBtn.gameObject.SetActive(true);
        QuitBtn.gameObject.SetActive(true);
        Options.gameObject.SetActive(true);
        BackBtn.gameObject.SetActive(false);
        SomInicio.PlayOneShot(clipe);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("NossoJogo/Levels/Necroterio");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Controls()
    {
        ControlsIg.SetActive(true);
        telaInicialImg.SetActive(false);
        PlayBtn.gameObject.SetActive(false);
        QuitBtn.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        BackBtn.gameObject.SetActive(true);
    }
    
    public void Back()
    {
        ControlsIg.SetActive(false);
        telaInicialImg.SetActive(true);
        PlayBtn.gameObject.SetActive(true);
        QuitBtn.gameObject.SetActive(true);
        Options.gameObject.SetActive(true);
        BackBtn.gameObject.SetActive(false);
    }
}
