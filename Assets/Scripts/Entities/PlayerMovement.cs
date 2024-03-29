using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        //_stats = GetComponent<CharacterStatsHandler>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    protected virtual void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
        //if (knockbackDuration > 0.0f)
        //{
        //    knockbackDuration -= Time.fixedDeltaTime;
        //}
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;//_stats.CurrentStats.speed;
        //if (knockbackDuration > 0.0f)
        //{
        //    direction += _knockback;
        //}
        _rigidbody.velocity = direction;
    }

}
