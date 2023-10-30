using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _coins;

    private void AddCoin()
    {
        _coins++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Coin coin))
        {
            AddCoin();
            Destroy(coin.gameObject); 

        }
    }
}