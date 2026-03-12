using UnityEngine;

public class TrapButton : MonoBehaviour
{
    [SerializeField] private GameObject _floor;
    [SerializeField] private GameObject _trapButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            _floor.SetActive(false);
            _trapButton.SetActive(false);
    }
}
