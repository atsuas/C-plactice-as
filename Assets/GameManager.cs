using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameObj;
    void Start()
    {
        //敵を消す際のスクリプト
        //gameObj.SetActive(false);

        //敵を破壊する際のスクリプト
        Destroy(gameObj);
    }

}
