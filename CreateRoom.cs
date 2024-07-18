using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class CreateRoom : MonoBehaviourPunCallbacks
{
    public TMP_InputField Odaismi;

    public TextMeshProUGUI odaName;

    private Lobi _lobi;

    public void FirstInitialize(Lobi canvases)
    {
        _lobi = canvases;
    }

    public void odakur()
    {
        if (!PhotonNetwork.IsConnected)
            return;

        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 2;
        PhotonNetwork.CreateRoom(Odaismi.text, options, TypedLobby.Default);
    }

    public override void OnCreatedRoom()
    {
        odaName.text = Odaismi.text;
        _lobi.Oda.Show();
    }
}
