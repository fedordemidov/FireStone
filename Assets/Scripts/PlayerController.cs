using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerController : NetworkBehaviour
{
    [SerializeField] private GameObject _camera;
    [SerializeField] private Canvas _nickName;
    [SerializeField] private GameObject _ui;
    [SerializeField] private MovementController _movementController;


    private void Start()
    {
        if (IsOwner)
        {
            _camera.SetActive(true);
            _nickName.enabled = false;
            _ui.SetActive(true);
            _movementController.enabled = true;
        }
        else
        {
            _camera.SetActive(false);
            _nickName.enabled = true;
            _ui.SetActive(false);
            _movementController.enabled = false;
        }
        
    }
}
