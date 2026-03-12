using UnityEngine;
using UnityEngine.SceneManagement;

public class DieZone : MonoBehaviour
{
    [SerializeField] private float _deathTime = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
