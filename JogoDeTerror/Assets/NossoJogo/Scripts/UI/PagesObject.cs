using UnityEngine;

public class PagesObject : MonoBehaviour
{
    public GameObject luz;
    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(gameObject);
                Destroy(luz);
            }
        }
    }
}
