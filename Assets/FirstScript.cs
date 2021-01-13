using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    //配列
    //宣言、代入、取得、長さ取得
    //for文との兼ね合い

    //List
    //宣言、代入、取得、長さ取得、追加、削除
    //for文との兼ね合い
    // foreach

    void Start()
    {
        List<int> number = new List<int>() { -1, 21, 23 };
        Debug.Log(number[0]);
        Debug.Log(number[1]);
        Debug.Log(number[2]);

        //代入
        number[1] = 0;
        Debug.Log(number[1]);

        //追加
        number.Add(100);
        Debug.Log(number[3]);

        //長さの取得
        Debug.Log(number.Count);

        //削除
        number.RemoveAt(1);
        number.Remove(-1);
        Debug.Log(number.Count);

        //for文
        for (int i = 0; i < number.Count; i++)
        {
            Debug.Log(number[i]);
        }

        // 0-9までのListを作成
        List<int> numberList = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            numberList.Add(i);
        }
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(numberList[i]);
        }

        //foreach (配列とListで使える)
        List<string> nameList = new List<string>() { "中野", "鈴木", "清水" };
        foreach (string Name in nameList)
        {
            Debug.Log(Name);
        }

        //演習 0-99までの3の倍数を要素にもつListを作れ
        List<int> num = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            num.Add(i);

            if (i%3 == 0)
            {
                Debug.Log(num[i]);
            }
        }

        List<int> test = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                test.Add(i);
            }
        }
        foreach (int ts in test)
        {
            Debug.Log(ts);
        }
    }
}
