using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellApple : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;

    public void ClickTheButton ()
    {
        if (GlobalApples.AppleCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough apples to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalApples.AppleCount -= 1;
            GlobalCash.CashCount += 1;
        }
    }


}
