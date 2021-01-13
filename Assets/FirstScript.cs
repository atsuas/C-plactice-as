using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // switch文
    // >, >=, <, <=, ==, !=
    void Start()
    {
        string charactorType = "Friend";

        //　演習 if文で書き換え
        if (charactorType == "Player")
        {
            Debug.Log("味方だよ");
        }
        else if (charactorType == "Enemy")
        {
            Debug.Log("敵だよ");
        }
        else if (charactorType == "Friend")
        {
            Debug.Log("友達だよ");
        }
        else
        {
            Debug.Log("その他");
        }

        //switch文
        switch (charactorType)
        {
            case "Player":
            Debug.Log("味方だよ");
            break;
            case "Enemy":
            Debug.Log("敵だよ");
            break;
            case "Friends":
            Debug.Log("友達だよ");
            break;
            default:
            Debug.Log("その他");
            break;  
        }
    }
}
