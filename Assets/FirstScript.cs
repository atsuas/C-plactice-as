using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //繰り返し
    //while
    //for
    //continue: 次の処理を行う
    //break：処理を抜ける
    void Start()
    {
        int x = 0;
        while (x < 10)
        {
            Debug.Log(x);
            x++;
        }

        for (int i = 0; i < 10; i++)
        {
            if (i == 7)
            {
                break;
            }
            Debug.Log(i);
        }

        for (int i = 0; i < 21; i++)
        {
            if (i%2 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
