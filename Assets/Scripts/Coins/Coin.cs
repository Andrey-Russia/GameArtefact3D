using NUnit.Framework.Constraints;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]private float _speed = 0.5f;
    [SerializeField]private float _amplitude = 0.5f;
    [SerializeField] private int _coinValue = 10;

    private void Update()
    {
        float yPosition = Mathf.Sin(Time.time  * _speed) * _amplitude;
        transform.localPosition += new Vector3(0, yPosition, 0);
        transform.Rotate(Vector3.up * Time.deltaTime * 90f);
    }

    internal int GetCoinValue()
    {
        return _coinValue;
    }
}
