using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingObject : MonoBehaviour
{
    [SerializeField] private float _fallSpeed = 10f;
    [SerializeField] private float _destroy = 1f;

    private Vector3 targetPosition;

    internal void Init(Vector3 targetPos)
    {
        targetPosition = targetPos;
    }

    private void Update()
    {
        MoveTowardsTarget();
    }

    private void MoveTowardsTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, _fallSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        else
            Destroy(gameObject, _destroy);
    }
}