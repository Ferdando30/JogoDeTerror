using UnityEngine;

public class PagesObject : MonoBehaviour
{
    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(gameObject);
            }
        }
    }
}
