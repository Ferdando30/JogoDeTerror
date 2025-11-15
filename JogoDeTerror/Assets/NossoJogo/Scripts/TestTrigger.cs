using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    public GameObject testObject;

    private void OnTriggerEnter(Collider other)
    {
        print("Trigger entered!");
        testObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
