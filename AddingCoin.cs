using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingCoin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CoinMove>())
        {
            Destroy(collision.gameObject);
        }
    }
}
