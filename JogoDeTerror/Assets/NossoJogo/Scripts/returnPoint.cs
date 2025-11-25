using UnityEngine;

public class returnPoint : MonoBehaviour
{
    public static Transform SpawnPoint;

    private void Awake()
    {
        SpawnPoint = transform;
        DontDestroyOnLoad(gameObject);
    }
}
