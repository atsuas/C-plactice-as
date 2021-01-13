using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log(Getmean(1, 10));
        Debug.Log(Getme(2, 20));
    }

    //平均を出す
    float Getmean(int n, int m)
    {
        float mean = 0f;
        for (int i = 0; i < m + 1; i++)
        {
            mean += i;
        }

        return mean/(m-n+1);
    }

    //こっちでもOK
    float Getme(int n, int m)
    {
        float mean = 0f;
        float sum = 0;
        int count = 0;

        for (int i = 0; i < m + 1; i++)
        {
            sum += i;
            count++;
        }

        mean = sum / count;
        return mean;
    }

}
