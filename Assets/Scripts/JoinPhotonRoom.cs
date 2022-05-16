using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using Photon.Realtime;
using TMPro;
public class JoinPhotonRoom : MonoBehaviourPunCallbacks
{

    [SerializeField]
    TMP_InputField _roomNameField;

    public void OnJoinRoomButtonClicked()
    {
        PhotonNetwork.JoinRoom(_roomNameField.text);
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        base.OnJoinRoomFailed(returnCode, message);
        Debug.Log("PUN: I have failed joining a room!"); 
    }


}
