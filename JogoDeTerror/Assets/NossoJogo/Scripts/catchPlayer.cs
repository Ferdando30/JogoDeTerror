using UnityEngine;

public class catchPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("COUNT THE MEDALS! 1, 2 AND 3!");

            playerMovement pm = other.GetComponent<playerMovement>();
            pm.RespawnPlayer();
        }
    }
} 
