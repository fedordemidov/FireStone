using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

[RequireComponent (typeof (Rigidbody))]
public class PlayerController : NetworkBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private VariableJoystick _joystick;
    [SerializeField] private GameObject _camera;

    [SerializeField] private float _moveSpeed;

    private void Start()
    {
        if (!IsOwner) return;
        _camera.SetActive(true);
    }

    private void FixedUpdate()
    {
        if (!IsOwner) return;
        Move();
    }

    private void Move()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);
    }
}
