using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;


public class PlayerNameCard : MonoBehaviourPun
{
    public Text nameText;

    void Start()
    {
        nameText.text = photonView.Owner.NickName; //PhotonNetwork.NickName;
        if (photonView.IsMine)
        {
            nameText.color = Color.blue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.localRotation = Quaternion.Euler(90, 0, 0);
        nameText.transform.rotation = Camera.main.transform.rotation;
    }
}