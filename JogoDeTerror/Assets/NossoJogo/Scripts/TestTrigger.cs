using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    public GameObject[] testObjects;
    public GameObject[] cercas;
    public bool inside;

    private void OnTriggerEnter(Collider other)
    {
        print("Trigger entered!");
        if (inside)
        {
            foreach (var obj in testObjects)
            {
                obj.GetComponent<MeshRenderer>().enabled = true;
                if (obj.GetComponent<BoxCollider>() != null)
                {
                    obj.GetComponent<BoxCollider>().enabled = true;
                }
                if (obj.GetComponent<MeshCollider>() != null)
                {
                    obj.GetComponent<MeshCollider>().enabled = true;
                }
            }
            foreach (var obj in cercas)
            {
                obj.GetComponent<MeshRenderer>().enabled = false;
                if (obj.GetComponent<BoxCollider>() != null)
                {
                    obj.GetComponent<BoxCollider>().enabled = false;
                }
                if (obj.GetComponent<MeshCollider>() != null)
                {
                    obj.GetComponent<MeshCollider>().enabled = false;
                }
            }
        }
        else
        {
            foreach (var obj in testObjects)
            {
                obj.GetComponent<MeshRenderer>().enabled = false;
                if (obj.GetComponent<BoxCollider>() != null)
                {
                    obj.GetComponent<BoxCollider>().enabled = false;
                }
                if (obj.GetComponent<MeshCollider>() != null)
                {
                    obj.GetComponent<MeshCollider>().enabled = false;
                }
            }
            foreach (var obj in cercas)
            {
                obj.GetComponent<MeshRenderer>().enabled = true;
                if (obj.GetComponent<BoxCollider>() != null)
                {
                    obj.GetComponent<BoxCollider>().enabled = true;
                }
                if (obj.GetComponent<MeshCollider>() != null)
                {
                    obj.GetComponent<MeshCollider>().enabled = true;
                }
            }
        }
    }
}
