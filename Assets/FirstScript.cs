using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    //配列
    //宣言、代入、取得、長さ取得
    //for文との兼ね合い

    void Start()
    {
        int[] xlist = new int[3];   //宣言 パターン１
        xlist[0] = 0;
        xlist[1] = 2;
        xlist[2] = -3;

        int[] xList = new int[3] { 0, 2, -3 };  //宣言 パターン２

        //取得
        Debug.Log(xList[0]);
        Debug.Log(xList[1]);
        Debug.Log(xList[2]);

        //長さの取得
        Debug.Log(xList.Length);

        //for文との連携
        for (int i = 0; i < xList.Length; i++)
        {
            Debug.Log(xList[i]);
        }

        //演習　0〜30の配列を表示する
        int[] yList = new int[31] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        for (int i = 0; i < yList.Length; i++)
        {
            Debug.Log(yList[i]);
        }

        //こっちで代入してもOK
        int[] tList = new int[31];
        for (int i = 0; i < 31; i++)
        {
            tList[i] = i;
        }

    }
}
