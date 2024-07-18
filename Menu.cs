using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private CreateRoom _createRoom;

    [SerializeField]
    private RoomListMenu _roomListMenu;

    private Lobi _lobi;

    public void FirstInitialize(Lobi canvases)
    {
        _lobi = canvases;
        _createRoom.FirstInitialize(canvases);
        _roomListMenu.FirstInitialize(canvases);
    }
}
