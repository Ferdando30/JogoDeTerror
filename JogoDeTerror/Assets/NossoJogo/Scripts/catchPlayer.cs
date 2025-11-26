using UnityEngine;
using System.Collections;

public class catchPlayer : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerMovement pm = other.GetComponent<playerMovement>();
            StartCoroutine(CatchSequence(pm));
        }
    }

    private IEnumerator CatchSequence(playerMovement pm)
    {
        yield return StartCoroutine(ScreenFader.Instance.FadeOut(1f));

        pm.RespawnPlayer();
    }
}