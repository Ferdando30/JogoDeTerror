using UnityEngine;

public class returnPoint : MonoBehaviour
{
    public static Transform SpawnPoint;
    public bool ReturningToLevel = false;

    private void Awake()
    {
        SpawnPoint = transform;
        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        
    }
}
