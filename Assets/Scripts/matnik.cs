using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
public class matnik : MonoBehaviour
{
    [SerializeField] private float _distance = 2f;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private bool useLocalPath = true;

    private void Start()
    {
        MoveObcstacle();
    }

    private void MoveObcstacle()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMove(useLocalPath ? transform.localPosition + Vector3.right * _distance : transform.position + Vector3.right * _distance, _duration / 2))
               .Append(transform.DOMove(useLocalPath ? transform.localPosition : transform.position, _duration / 2))
               .SetLoops(-1, LoopType.Restart);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
