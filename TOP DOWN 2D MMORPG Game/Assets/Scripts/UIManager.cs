using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Netcode;

public class UIManager : MonoBehaviour
{

    public Button startServerBtn,startClientBtn, startHostButton;

    private void Start() {
        startHostButton.onClick.AddListener(() =>
        {
            if(NetworkManager.Singleton.StartHost())
            {
                Debug.Log("Host Started...");
            }
            else
            {
                Debug.Log("Host could not be started...");
            }
        });

        startClientBtn.onClick.AddListener(() =>
        {
            if(NetworkManager.Singleton.StartClient())
            {
                Debug.Log("Client Started...");
            }
            else
            {
                Debug.Log("Client could not be started...");
            }
        });

        startServerBtn.onClick.AddListener(() =>
        {
            if(NetworkManager.Singleton.StartServer())
            {
                Debug.Log("Server Started...");
            }
            else
            {
                Debug.Log("Server could not be started...");
            }
        });
    }
    
}
