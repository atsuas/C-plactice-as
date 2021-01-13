using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // if文
    // >, >=, <, <=, ==, !=
    void Start()
    {
        int hp = 9;

        if (hp > 150)
        {
            Debug.Log("攻撃だー！");
        }
        else if (hp > 80)
        {
            Debug.Log("そろそろHPやばいよ！");
        }
        else
        {
            Debug.Log("回復して！！");
        }

        //　偶数か奇数を求める
        if (hp%2 == 0)
        {
            Debug.Log("HPは偶数");
        }
        else if (hp%2 == 1)
        {
            Debug.Log("HPは奇数");
        }

        //　演習
        if (hp%3 == 1)
        {
            Debug.Log("余りは１");
        }
        else if (hp%3 == 2)
        {
            Debug.Log("余りは２");
        }
        else if (hp%3 == 0)
        {
            Debug.Log("余りは０");
        }
        else
        {
            Debug.Log("その他");
        }
    }

    void Update()
    {
        
    }
}
