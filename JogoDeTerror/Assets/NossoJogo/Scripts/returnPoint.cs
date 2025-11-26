using UnityEngine;

public class returnPoint : MonoBehaviour
{
    public static returnPoint Instance;
    public static Transform SpawnPoint;
    public bool ReturningToLevel = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            SpawnPoint = transform;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}