using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] shapePrefabs;
    public Transform spawnPoint;

    void Start()
    {
        SpawnNewShape();
    }

    public void SpawnNewShape()
    {
        int index = Random.Range(0, shapePrefabs.Length);
        Instantiate(shapePrefabs[index], spawnPoint.position, Quaternion.identity);
    }
}