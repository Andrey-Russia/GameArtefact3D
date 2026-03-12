using UnityEngine;
using UnityEngine.SceneManagement;

public class DungerZone : MonoBehaviour
{
    [SerializeField] private GameObject _fallPrefab;
    [SerializeField] private float _spawnHeight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            SpawnFallingObject(other.transform.position);
    }

    private void SpawnFallingObject(Vector3 position)
    {
        Vector3 spawnPosition = position + Vector3.up * _spawnHeight;
        GameObject fallingObject = Instantiate(_fallPrefab, spawnPosition, Quaternion.identity);
        fallingObject.GetComponent<FallingObject>().Init(position); 
    }
}
