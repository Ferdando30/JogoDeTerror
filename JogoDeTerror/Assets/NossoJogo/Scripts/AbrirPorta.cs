using UnityEngine;
using TMPro;

public class AbrirPorta : MonoBehaviour
{
    public GameObject PortaD;
    public GameObject PortaE;
    public TextMeshProUGUI PressUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PortaD.transform.rotation = Quaternion.Euler(-90f, 0f, -180f);
        PortaE.transform.rotation = Quaternion.Euler(-90f, 0f, -180f);
        PressUI.enabled = false;
    }

    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Player")
        {
            PressUI.enabled = true;
            if (Input.GetKey(KeyCode.E))
            {
                PortaD.transform.rotation = Quaternion.Euler(-90f, 0f, 90f);
                PortaE.transform.rotation = Quaternion.Euler(-90f, 0f, -90f);
            }
        }
    }
    void OnTriggerExit(Collider hit)
    {
        PressUI.enabled = false;
    }
}
