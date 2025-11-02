using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.HighDefinition.ScalableSettingLevelParameter;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("NossoJogo/Levels/Necroterio");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
