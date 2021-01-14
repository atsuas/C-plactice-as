using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputUserKey : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");
        //Debug.Log(x+","+y);

        bool onSpace = Input.GetKey("space");
        if (onSpace)
        {
            Debug.Log("攻撃");
        }
    }
}
