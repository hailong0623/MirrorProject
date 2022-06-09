using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    void PlayerMove()
    {
        if (isLocalPlayer)
        {
            float _horizontal = Input.GetAxis("Horizontal");
            float _vertical = Input.GetAxis("Vertical");
            Vector3 offset = new Vector3(_horizontal * 0.05f, _vertical * 0.05f, 0);
            transform.position = transform.position + offset;
        }
    }

    private void Update()
    {
        PlayerMove();
    }
}
