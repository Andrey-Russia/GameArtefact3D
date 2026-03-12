using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] private float _collectDistance = 1.5f;
    [SerializeField] private WalletManager walletManager;

    private Coin coinScript;

    private void Start()
    {
        coinScript = GetComponent<Coin>();
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            if (Physics.Raycast(transform.position, Vector3.down, out hit))
            {
                if (hit.collider.CompareTag("Player") && Vector3.Distance(hit.point, transform.position) <= _collectDistance)
                {
                    walletManager.AddCoins(coinScript.GetCoinValue());
                    Destroy(gameObject);
                }
            }
        }
    }
}