using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Sunucu : MonoBehaviourPunCallbacks
{

    void Start()
    {
        print("Sunucuya Bağlanılıyor");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print("Sunucuya Bağlanıldı");
        if(!PhotonNetwork.InLobby)
            PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        print("Lobiye Girildi");
    }
}
