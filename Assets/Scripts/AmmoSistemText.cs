using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoSistemText : MonoBehaviour
{
    Text text;
    public static int BulletPlus = 15;
    
    void Start()
    {
        text = GetComponent<Text>();
        BulletPlus = 15;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = BulletPlus.ToString();
    }
}
