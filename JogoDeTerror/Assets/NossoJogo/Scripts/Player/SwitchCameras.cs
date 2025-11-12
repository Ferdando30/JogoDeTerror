using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SwitchCameras : MonoBehaviour
{
    public GameObject CameraPlayer;
    public GameObject HiddenSpot;
    public int Manager;
    public Animator Image;

    void Start()
    {
        CameraPlayer.SetActive(true);
        HiddenSpot.SetActive(false);
        Manager = 0;
        //Image = GetComponent<Animator>();
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
            if(Manager == 0)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    StartCoroutine(GoTo());

                }
            }
        }
    }

    IEnumerator GoTo()
    {
        Image.SetBool("Fade", true);
        yield return new WaitForSeconds(1.3f);
        Image.SetBool("Fade", false);
        CameraPlayer.SetActive(false);
        HiddenSpot.SetActive(true);
        Manager = 1;
    }

    IEnumerator GoBack()
    {
        Image.SetBool("Fade", true);
        yield return new WaitForSeconds(1.3f);
        Image.SetBool("Fade", false);
        CameraPlayer.SetActive(true);
        HiddenSpot.SetActive(false);
        Manager = 0;
    }

}
