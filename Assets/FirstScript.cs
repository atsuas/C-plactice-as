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


    //演算　+,-,*,/,%,+=,++,--,&&,||,!

    void Start()
    {
        int a = 10;
        int b = 2;
        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a * b);
        Debug.Log(a / b);
        Debug.Log(b / a);

        float c = 10.0f;
        float d = 2.0f;
        Debug.Log(d / c);

        int n = 10;
        int m = 3;
        Debug.Log(n / m);
        Debug.Log(n % m);
        Debug.Log(10 % 2);
        Debug.Log(9 % 2);

        int x = 10;
        x += 1;     // x = x + 1
        x++;        // x = x + 1




    }

    void Update()
    {
        
    }
}
