using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    //当たった物の名前をコンソールに表示してくれる
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }
}
