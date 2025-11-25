using UnityEngine;

public class playSound : MonoBehaviour
{
    public AudioSource Som;
    public AudioClip clipe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Som.PlayOneShot(clipe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
