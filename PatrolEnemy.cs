using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private int _direction;

    private void Start()
    {
        _direction = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<MovementPlayer>())
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 50000);
        }
        _direction *= -1;
    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * _direction, 0, 0);
    }
}
