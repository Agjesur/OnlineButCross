using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Lobi : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Menu _Menu;
    public Menu Menu { get { return _Menu; } }

    [SerializeField]
    private Oda _Oda;
    public Oda Oda { get { return _Oda; } }

    private void Awake()
    {
        FirstInitialize();
    }

    private void FirstInitialize ()
    {
        Menu.FirstInitialize(this);
        Oda.FirstInitialize(this);
    }

}
