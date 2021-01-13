using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdataText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text sampleText = GetComponent<Text>();
        sampleText.text = "atsu";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
