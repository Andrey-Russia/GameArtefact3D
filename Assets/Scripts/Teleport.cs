using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private GameObject _messagePanel;
    [SerializeField] private WalletManager _walletManager;

    private void Awake()
    {
        HidePanel();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = _target.transform.position;
            other.transform.rotation = _target.transform.rotation;
            _walletManager.EnableCanvas();
            ShowPanel();
        }
    }

    private void Update()
    {
        if (_messagePanel.activeInHierarchy && Input.anyKeyDown)
        {
            HidePanel();
        }
    }

    private void ShowPanel()
    {
        _messagePanel.SetActive(true);
    }

    private void HidePanel()
    {
        _messagePanel.SetActive(false);
    }
}