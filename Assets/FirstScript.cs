using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //変数の型
    //文字列型:
    string Name = "中野";
    //整数：
    int hp = 100;
    //浮動小数点数:
    float speed = 3.11f;
    //論理値：
    bool flag1 = true;
    bool flag2 = false;


    void Start()
    {
        Debug.Log(Name);
        Debug.Log(hp);
        Debug.Log(speed);
        Debug.Log(flag1);
        Debug.Log(flag2);
    }

    void Update()
    {
        
    }
}
