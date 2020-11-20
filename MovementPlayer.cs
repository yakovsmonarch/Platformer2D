using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    
    private Rigidbody2D _rigidbody2D;
    private bool _isGround;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _isGround = true;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * -Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if(_isGround == true)
            {
                _isGround = false;
                _rigidbody2D.AddForce(Vector2.up * _jumpForce);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isGround = true;
    }
}
