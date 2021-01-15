using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreater : MonoBehaviour
{
    //public
    //エフェクトを付ける際に使用したりする
    [SerializeField] GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(playerPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
