using UnityEngine;

public class AbrirPorta : MonoBehaviour
{
    public GameObject PortaD;
    public GameObject PortaE;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PortaD.transform.rotation = Quaternion.Euler(-90f, 0f, -180f);
        PortaE.transform.rotation = Quaternion.Euler(-90f, 0f, -180f);
    }

    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                PortaD.transform.rotation = Quaternion.Euler(-90f, 0f, 90f);
                PortaE.transform.rotation = Quaternion.Euler(-90f, 0f, -90f);
            }
        }
    }
}
