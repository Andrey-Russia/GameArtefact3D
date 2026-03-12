using UnityEngine;
using TMPro;

public class WalletManager : MonoBehaviour
{
    [SerializeField] private Canvas _balance;
    [SerializeField] private TMP_Text _balanceText;
    [SerializeField] private int _startCoin = 0;

    private int _currentCoins;

    private void Start()
    {
        _currentCoins = _startCoin;
        _balance.enabled = false;
        UpdateBalanceDisplay();
    }

    public void AddCoins(int amount)
    {
        _currentCoins += amount;
        UpdateBalanceDisplay();
    }

    private void UpdateBalanceDisplay()
    {
        _balanceText.text = $"Баланс: {_currentCoins}";
    }

    public void EnableCanvas()
    {
        _balance.enabled = true;
    }
}