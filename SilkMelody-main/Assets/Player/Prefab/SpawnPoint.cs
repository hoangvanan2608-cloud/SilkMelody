using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private void Start()
    {
        if (Player.instance != null)
        {
            Player.instance.transform.position = transform.position;
        }
    }
}