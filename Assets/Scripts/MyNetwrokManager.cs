using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetwrokManager : NetworkManager
{
    public override void OnStartServer()
    {
        Debug.Log(("Server Started."));
    }

    public override void OnStopServer()
    {
        Debug.Log("Server Stoped.");
    }

    public override void OnClientConnect()
    {
        Debug.Log("Client Connect Server");
    }

    public override void OnClientDisconnect()
    {
        Debug.Log("Client Disconnect Server");
    }
}
