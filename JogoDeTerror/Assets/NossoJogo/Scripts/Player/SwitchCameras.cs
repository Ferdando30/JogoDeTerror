using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class SwitchCameras : MonoBehaviour
{
    public GameObject CameraPlayer;
    public GameObject HiddenSpot;
    public int Manager;
    public Animator Image;

    public GameObject PlayerObj;
    private Rigidbody rb;
    public float X;
    public float Y;
    public float Z;
    public TextMeshProUGUI PressUI;


    void Start()
    {
        CameraPlayer.SetActive(true);
        HiddenSpot.SetActive(false);
        Manager = 0;
        rb = PlayerObj.GetComponent<Rigidbody>();
        PressUI.enabled = false;

    }

    void Update()
    {
        if(Manager == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(GoBack());
                

            }
        }
    }

    

    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Player")
        {
            PressUI.enabled = true;
            if (Manager == 0)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    StartCoroutine(GoTo());
                    

                }
            }
        }
    }
    void OnTriggerExit(Collider hit)
    {
        PressUI.enabled = false;
    }

    IEnumerator GoTo()
    {
        Image.SetBool("Fade", true);
        yield return new WaitForSeconds(1.3f);
        rb.position = new Vector3(100, 100, 100);
        
        Image.SetBool("Fade", false);
        CameraPlayer.SetActive(false);
        HiddenSpot.SetActive(true);
        Manager = 1;
    }

    IEnumerator GoBack()
    {
        Image.SetBool("Fade", true);
        yield return new WaitForSeconds(1.3f);
        rb.position = new Vector3(X, Y, Z);
        
        Image.SetBool("Fade", false);
        CameraPlayer.SetActive(true);
        HiddenSpot.SetActive(false);
        Manager = 0;
    }

}
