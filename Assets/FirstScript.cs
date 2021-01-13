using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //列挙型

    public enum TYPE
    {
        STOP,
        RIGHT,
        LEFT
    }

    TYPE type = TYPE.STOP;

    void Start()
    {
        if (type == TYPE.STOP)
        {
            Debug.Log(type);
        }
    }

}
