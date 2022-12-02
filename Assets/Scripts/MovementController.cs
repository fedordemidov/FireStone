using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

[RequireComponent (typeof (Rigidbody))]
public class MovementController : NetworkBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private VariableJoystick _joystick;
    [SerializeField] private Transform _body;
    [SerializeField] private Animator _animator;
    
    [SerializeField] private float _moveSpeed;
    [SerializeField] private NetworkVariable<Vector3> networPositionDirection = new NetworkVariable<Vector3>();
    [SerializeField] private NetworkVariable<Vector3> networRotationDirection = new NetworkVariable<Vector3>();

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);
        
        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            _body.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("Run", true);
        }
        else
        {
            _animator.SetBool("Run", false);
        }
    }
}
