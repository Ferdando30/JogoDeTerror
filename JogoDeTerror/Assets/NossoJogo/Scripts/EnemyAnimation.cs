using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    private Animator WalkingAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WalkingAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        WalkingAnimator.SetFloat("WSpeed", 1);
    }
}
