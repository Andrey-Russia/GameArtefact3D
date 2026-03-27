using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _speed = 0.5f;
    [SerializeField] private float _amplitude = 0.5f;
    [SerializeField] private float _rotationSpeed = 90f;

    private int _coinValue;

    private void Awake()
    {
        _coinValue = Random.Range(1, 11);
    }

    private void Update()
    {
        float yPosition = Mathf.Sin(Time.time * _speed) * _amplitude;
        transform.localPosition += new Vector3(0,0, 0);
        transform.Rotate(new Vector3(_rotationSpeed, _rotationSpeed, _rotationSpeed) * Time.deltaTime);
    }

    internal int GetCoinValue()
    {
        return _coinValue;
    }
}