﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerSetUp : MonoBehaviour {

    public bool isMe;
    public int playerNumber;

    public SpheareType myType;
    
    public void Init()
    {
        this.myType = SpheareType.Red;
    }

}
