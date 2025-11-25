using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DoorExit : MonoBehaviour
{
    public GameObject book;
    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page3;
    public GameObject Page4;
    public GameObject Page5;
    public GameObject Page6;
    public TextMeshProUGUI PressUI;
    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Player")
        {
            PressUI.enabled = true;
            if (book == null && Page1 == null && Page2 == null && Page3 == null && Page4 == null && Page5 == null & Page6 == null)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    SceneManager.LoadScene("NossoJogo/Levels/Necroterio");
                }
            }
        }
    }
    void OnTriggerExit(Collider hit)
    {
        PressUI.enabled = false;
    }
}
