using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using System;
using TMPro;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button serverButton;
    [SerializeField] private Button hostButton;
    [SerializeField] private Button clientButton;

    private void Awake()
    {
        serverButton.onClick.AddListener(() => 
        {
            NetworkManager.Singleton.StartServer();
        });

        hostButton.onClick.AddListener(() => 
        {
            NetworkManager.Singleton.StartHost();
        });

        clientButton.onClick.AddListener(() => 
        {
            NetworkManager.Singleton.StartClient();
        });
    }

    private void Update()
    {
        //players.text = $"Players in game: {PlayerManager.Instance.PlayersInGame}";
    }
}
