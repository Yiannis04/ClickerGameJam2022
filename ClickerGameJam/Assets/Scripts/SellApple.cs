using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellApple : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton ()
    {
        GlobalApples.AppleCount -= 1;
        GlobalCash.CashCount += 1;
    }


}
