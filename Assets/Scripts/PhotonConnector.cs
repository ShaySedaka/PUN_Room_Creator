using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class PhotonConnector : MonoBehaviourPunCallbacks
{

    [SerializeField]
    GameObject _connectedLabel;


    void Awake()
    {
        // this makes sure we can use PhotonNetwork.LoadLevel() on the master client and all clients in the same room sync their level automatically
        PhotonNetwork.AutomaticallySyncScene = true;
    }
    private void Start()
    {
        Debug.Log("Start is called");

        if (!PhotonNetwork.IsConnected)
        {
            Debug.Log("Trying to connect");
            PhotonNetwork.ConnectUsingSettings();
        }   
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMaster() was called by PUN");
        _connectedLabel.SetActive(true);

        if (!PhotonNetwork.InLobby)
        {
            TypedLobby customLobby = new TypedLobby("customLobby", LobbyType.Default);
            PhotonNetwork.JoinLobby(customLobby);
        }

}



    public void LoadRoomLevel()
    {
        if (!PhotonNetwork.IsMasterClient)
        {
            Debug.LogError("PhotonNetwork : Trying to Load a level but we are not the master Client");
        }

        Debug.LogFormat("PhotonNetwork : Loading Level...");
        PhotonNetwork.LoadLevel("RoomScene");
    }

    public override void OnJoinedRoom()
    {
        LoadRoomLevel();
    }


}
