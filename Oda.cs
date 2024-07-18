using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oda : MonoBehaviour
{
    [SerializeField]
    private PlayerListMenu _playerListMenu;
    [SerializeField]
    private LeaveRoom _leaveRoom;

    private Lobi _lobi;

    public void FirstInitialize (Lobi canvases)
    {
        _lobi = canvases;
        _playerListMenu.FirstInitialize(canvases);
        _leaveRoom.FirstInitialize(canvases);
    }

    public void Show ()
    {
        gameObject.SetActive(true);
    }

    public void Hide ()
    {
        gameObject.SetActive(false);
    }
}
