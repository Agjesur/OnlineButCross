using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerListMenu : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Transform _content;
    [SerializeField]
    private PlayerList _Playerlist;

    private List<PlayerList> _listings = new List<PlayerList>();
    private Lobi _lobi;

    private void Awake()
    {
        GetOdaPlayer();
    }

    public void FirstInitialize(Lobi canvases)
    {
        _lobi = canvases;
    }

    public override void OnLeftRoom()
    {
        _content.DestroyChild();
    }

    private void GetOdaPlayer()
    {
        foreach (KeyValuePair<int, Player> playerInfo in PhotonNetwork.CurrentRoom.Players)
        {
            AddPlayerList(playerInfo.Value);
        }
    }

    private void AddPlayerList(Player player)
    {
        PlayerList listing = Instantiate(_Playerlist, _content);
        if (listing != null)
        {
            listing.SetPlayerInfo(player);
            _listings.Add(listing);
        }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        AddPlayerList(newPlayer);
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        int index = _listings.FindIndex(x => x.Player == otherPlayer);
        if (index != -1)
        {
            Destroy(_listings[index].gameObject);
            _listings.RemoveAt(index);
        }
    }

}
