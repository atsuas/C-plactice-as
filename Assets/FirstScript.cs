using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    void Start()
    {
        PlayerModel player = new PlayerModel("koko");
        player.SayName();
    }
}
