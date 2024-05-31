using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagaer : MonoBehaviour
{
    #region Singleton

    public static PlayerManagaer instance;

    void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject player;
}
