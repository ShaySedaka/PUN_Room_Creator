using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using Photon.Realtime;
using TMPro;

public class CreatePhotonRoom : MonoBehaviourPunCallbacks
{

    [SerializeField]
    TMP_InputField _roomNameField;

    public void OnRoomCreateButtonClicked()
    {
        PhotonNetwork.CreateRoom(_roomNameField.text, new RoomOptions());
    }
    public override void OnCreatedRoom()
    {

    }



}
