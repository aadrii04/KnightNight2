
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoinController : MonoBehaviour
{
    public UnityEvent collectCoinScore;

    private void OnTriggerEnter2D(Collider2D other)
    {
        collectCoinScore.Invoke();
        gameObject.SetActive(false);

    }
}

