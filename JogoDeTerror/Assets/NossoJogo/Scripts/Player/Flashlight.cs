using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashLight;
    bool ligado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ligado = false;
       flashLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ligado == false)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                ligado = true;
                flashLight.SetActive (true);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                ligado = false;
                flashLight.SetActive(false);
            }
        }

    }
    
}
