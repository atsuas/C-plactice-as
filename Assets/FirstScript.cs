using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int[] numberList1 = new int[3] { 2, -4, 10 };
    int[] numberList2 = new int[4] { 2, -4, 10, 100 };

    void Start()
    {
        Debug.Log(GetMaxValue(numberList1));
        Debug.Log(GetMaxValue(numberList2));
    }

    //　↓ここでGetMaxValueを作ってしまうとラクにできる
    int GetMaxValue(int[] numberList)
    {
        int maxValue = numberList[0];
        for (int i = 0; i < numberList.Length; i++)
        {
            if (maxValue < numberList[i])
            {
                maxValue = numberList[i];
            }
        }
        return maxValue;
    }
    //　↑ここまで

    // ↓１つずつ求める場合
    int GetMaxValue1()
    {
        int maxValue = numberList1[0];
        for (int i = 0; i < numberList1.Length; i++)
        {
            if (maxValue < numberList1[i])
            {
                maxValue = numberList1[i];
            }
        }
        return maxValue;
    }

    int GetMaxValue2()
    {
        int maxvalue2 = numberList2[0];
        for (int i = 0; i < numberList2.Length; i++)
        {
            if (maxvalue2 < numberList2[i])
            {
                maxvalue2 = numberList2[i];
            }
        }
        return maxvalue2;
    }
}
