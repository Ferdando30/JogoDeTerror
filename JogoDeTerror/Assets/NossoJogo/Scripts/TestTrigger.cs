using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    public GameObject[] testObjects;
    public bool inside;

    private void OnTriggerEnter(Collider other)
    {
        print("Trigger entered!");
        if (inside)
        {
            foreach (var obj in testObjects)
            {
                obj.GetComponent<MeshRenderer>().enabled = true;
                obj.GetComponent<BoxCollider>().enabled = true;
            }
        }
        else
        {
            foreach (var obj in testObjects)
            {
                obj.GetComponent<MeshRenderer>().enabled = false;
                obj.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
}
