using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalApples : MonoBehaviour
{
    public static int AppleCount; 
    public GameObject AppleDisplay; 
    public int InternalApple;

    // Update is called once per frame
    void Update()
    {
        InternalApple = AppleCount;
        AppleDisplay.GetComponent<Text>().text = "Apples: " + InternalApple;
    }
}
