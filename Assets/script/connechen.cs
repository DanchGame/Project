using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class connechen : MonoBehaviourPunCallbacks
{
    private void OnConnectedToMaster()
    {
        SceneManager.LoadScene("playsetting");
    }
}
