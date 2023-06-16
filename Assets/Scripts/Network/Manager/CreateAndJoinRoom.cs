using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;
    public TMP_InputField joinInput;

    public void CreateRoom()
    {
        if (createInput.text == "")
            return;
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 2;
        options.PublishUserId = true;

        PhotonNetwork.CreateRoom(createInput.text, options, null);

        Debug.Log("Room " + createInput.text + " was created");
    }

    public void JoinRoom()
    {
        if (joinInput.text == "")
            return;

        PhotonNetwork.JoinRoom(joinInput.text);
        Debug.Log("Room " + joinInput.text + " joined");
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
