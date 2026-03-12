using UnityEngine;

public class Wallbutton : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private Material _active;
    [SerializeField] private Material _inactive;

    private Renderer _buttonRenderer;

    private void Start()
    {
        _buttonRenderer = GetComponent<Renderer>();
        DeactivateWall();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            ActivateWall();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            DeactivateWall();
    }

    internal void ActivateWall()
    {
        _gameObject.SetActive(false);
        ChangeButtonColor(_active);
    }

    internal void DeactivateWall()
    {
        _gameObject.SetActive(true);
        ChangeButtonColor(_inactive);
    }

    internal void ChangeButtonColor(Material material)
    {
        if (_buttonRenderer != null)
            _buttonRenderer.material = material;
    }
}
