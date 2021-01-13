using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    
    void Start()
    {
        //GetLog1To10();
        //GetNumber(3, 22);
        Debug.Log(GetSum(1, 10));
    }

    int GetSum (int n, int m)
    {
        int sum = 0;
        for (int i = n; i < m + 1; i++)
        {
            sum = sum + i;
        }
        return sum;
    }

    void GetNumber(int n, int m)
    {
        for (int i = n; i < m + 1; i++)
        {
            Debug.Log(i);
        }
    }

    void GetLog1To10()
    {
        for (int i = 0; i < 11; i++)
        {
            Debug.Log(i);
        }
    }
}
