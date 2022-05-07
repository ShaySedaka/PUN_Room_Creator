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

    [SerializeField]
    PhotonConnector _photonConnector;   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRoomCreateButtonClicked()
    {
        PhotonNetwork.CreateRoom(_roomNameField.text, new RoomOptions());
    }
    public override void OnCreatedRoom()
    {

    }

    public override void OnJoinedRoom()
    {
        _photonConnector.LoadRoomLevel();
    }


}
