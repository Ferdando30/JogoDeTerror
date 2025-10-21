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
            if (Input.GetKey(KeyCode.F))
            {
                Image.SetTrigger("Change");
                CameraPlayer.SetActive(true);
                HiddenSpot.SetActive(false);
                Manager = 0;
            }
        }
    }

    void GoToSpot()
    {
        Image.SetTrigger("Change");
        CameraPlayer.SetActive(false);
        HiddenSpot.SetActive(true);
        Manager = 1;
    }

    void OnTriggerStay(Collider hit)
    {
        if (Input.GetKey(KeyCode.E))
        {
            GoToSpot();
        }
    }
}
