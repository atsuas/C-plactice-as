using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    void Start()
    {
        PlayerModel player = new PlayerModel("koko");
        Debug.Log(player.Name);
        player.Name = "xxxx";
        Debug.Log(player.Name);
        //Debug.Log(player.hp);
        //Debug.Log(player.at);
    }
}
