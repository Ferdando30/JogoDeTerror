using UnityEngine;
using TMPro;

public class PagesObject : MonoBehaviour
{
    public GameObject luz;
    public TextMeshProUGUI PressUI;
    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Player")
        {
            PressUI.enabled = true;
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(gameObject);
                Destroy(luz);
                PressUI.enabled = false;
            }
        }
    }
    void OnTriggerExit(Collider hit)
    {
        PressUI.enabled = false;
    }
}
