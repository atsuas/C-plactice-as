using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //関数（メソッド）：処理をまとめた便利道具

    void Start()
    {
        string name1 = SampleNameFunction("atsu");
        string name2 = SampleNameFunction("yamada");
        Debug.Log(name1);
        Debug.Log(name2);


        Debug.Log(SampleAddfunction(10, 2));
    }

    string SampleNameFunction(string sampleName)
    {
        Debug.Log(sampleName);
        return sampleName + "さん";
    }

    //四則演算
    int SampleAddfunction(int a, int b)
    {
        return a + b;
    }
}
