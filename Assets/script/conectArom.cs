using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using Photon.Realtime;

public class conectArom : MonoBehaviourPunCallbacks
{
public InputField InputFieldNameRoom;

    public void CreateRoom()
    {
        RoomOptions roomsOprion = new RoomOptions();
        roomsOprion.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(InputFieldNameRoom.text, roomsOprion);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(InputFieldNameRoom.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("SampleScene");
    }
}

