using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LeaveRoom : MonoBehaviour
{

    private Lobi _lobi;

    public void FirstInitialize(Lobi canvases)
    {
        _lobi = canvases;
    }

    public void ClickedLeaveRoom ()
    {
        PhotonNetwork.LeaveRoom(true);
        _lobi.Oda.Hide();
    }

}
