using Photon.Realtime;
using TMPro;
using UnityEngine;

public class RoomProfileUIBtn : MonoBehaviour
{
    public TextMeshProUGUI roomName;


    public void SetRoomProfile(RoomProfile roomProfile)
    {
        roomName.text = roomProfile.name;
    }

    public void SetRoomProfile(RoomInfo roomInfo)
    {
        roomName.text = roomInfo.Name;
    }

    public void OnThisRoomClick()
    {
        
    }
}
