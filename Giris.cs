using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class Giris : MonoBehaviourPunCallbacks
{
    public TMP_InputField isim;

    public void isimbelirle ()
    {
        if (!PhotonNetwork.IsConnected)
            return;
        if(isim.text == "")
            return;
        PhotonNetwork.NickName = isim.text;
        gameObject.SetActive(false);
    }
}
