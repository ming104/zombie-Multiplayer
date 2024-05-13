using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using UnityEngine.UI;

public class PlayerInfoList : MonoBehaviourPun
{
    //public GameObject playerinfomation;
    public GameObject playerBoxGame;
    private Transform _targetTransform;
    // Start is called before the first frame update
    private void Awake()
    {
        _targetTransform = transform;
    }

    void OnEnable()
    {
        UpdatePlayerList();
    }

    private void OnDisable()
    {
        if (_targetTransform.childCount > 0)
        {
            foreach (Transform child in _targetTransform)
            {
                Destroy(child.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdatePlayerList()
    {
        // 현재 방에 있는 모든 플레이어에 대해 반복
        foreach (Player player in PhotonNetwork.PlayerList)
        {

        }
    }
}
