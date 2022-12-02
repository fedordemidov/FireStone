using Unity.Collections;
using Unity.Netcode;
using System;
using TMPro;

public class PlayerHub : NetworkBehaviour
{
    public TextMeshProUGUI localPlayerOverlay;
    private NetworkVariable<NetworkString> playersName = new NetworkVariable<NetworkString>();

    private bool overlaySet = false;

    public override void OnNetworkSpawn()
    {
        if (IsServer)
        {
            playersName.Value = $"Player {OwnerClientId }";
        }
    }

    public void SetOverlay()
    {
        if (localPlayerOverlay == null)
        {
            localPlayerOverlay = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        }
        localPlayerOverlay.text = playersName.Value;
    }

    private void Update()
    {
        if (!overlaySet && !string.IsNullOrEmpty(playersName.Value))
        {
            SetOverlay();
            overlaySet = true;
        }
    }
}