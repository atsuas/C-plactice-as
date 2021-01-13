using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //変数と定数
    //変数：値を変えられるもの
    //変数の型　変数名;
    void Start()
    {
        string say = "Hello world";
        Debug.Log(say);

        const string saycon = "Hello world2";
        Debug.Log(saycon);
    }

    void Update()
    {
        
    }
}
