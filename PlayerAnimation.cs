using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey (KeyCode.A))
        {
            _animator.SetBool("Run", true);

            if (Input.GetKey(KeyCode.D))
            {
                _spriteRenderer.flipX = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                _spriteRenderer.flipX = true;
            }
        }
        else
        {
            _animator.SetBool("Run", false);
        }
    }
}
