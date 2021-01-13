using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //整数nからmまでの偶数の和を返す関数を作成

    void Start()
    {
        int sumAll = GetSum(1, 100);
        int sumEven = GetSumEven(1, 100);
        int sumOdd = GetSumOdd(1, 100);
        Debug.Log(sumAll);
        Debug.Log(sumEven);
        Debug.Log(sumOdd);
        if (sumAll == sumEven + sumOdd)
        {
            Debug.Log("OK!!!");
        }

    }

    int GetSum(int n, int m)
    {
        int sum = 0;
        for (int i = n; i < m + 1; i++)
        {
            sum += i;
        }
        return sum;
    }

    int GetSumEven(int n, int m)
    {
        int sum = 0;
        for (int i = n; i < m + 1; i++)
        {
            if (i%2 == 0)
            {
                sum += i;
            }
            
        }
        return sum;
    }

    int GetSumOdd(int n, int m)
    {
        int sum = 0;
        for (int i = n; i < m + 1; i++)
        {
            if (i % 2 == 1)
            {
                sum += i;
            }

        }
        return sum;
    }
}
