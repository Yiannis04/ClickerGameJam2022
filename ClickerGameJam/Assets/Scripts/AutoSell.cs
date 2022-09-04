using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{

    public bool SellingApple = false;
    public static int CashIncrease = 1;
    public int InternalIncrease; 

    // Update is called once per frame
    void Update()
    {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
        if (SellingApple == false)
        {
            SellingApple = true; 
            StartCoroutine(SellTheApple());
        }
    }

    IEnumerator SellTheApple ()
    {
        if (GlobalApples.AppleCount == 0)
        {
            //We can't do anything
        }
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalApples.AppleCount -= 1;
            yield return new WaitForSeconds(1);
            SellingApple = false;
        }
    }
}
