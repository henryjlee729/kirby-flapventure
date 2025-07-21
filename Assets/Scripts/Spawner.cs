using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Walls prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 2f;
    public float verticalGap = 3f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        Walls walls = Instantiate(prefab, transform.position, Quaternion.identity);
        walls.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        walls.gap = verticalGap;
    }

}