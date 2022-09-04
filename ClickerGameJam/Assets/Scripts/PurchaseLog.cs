using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{

    public GameObject AutoApple; 
    public GameObject AutoSell; 


    public void StartAutoApple ()
    {
        AutoApple.SetActive(true);
        GlobalCash.CashCount -= GlobalPicker.pickerValue;
        GlobalPicker.pickerValue *= 2;
        GlobalPicker.turnOffButton = true;
        GlobalPicker.pickPerSec += 1;
        GlobalPicker.numberOfPickers += 1;
    }

    public void StartAutoSell ()
    {
        AutoSell.SetActive(true);
        GlobalCash.CashCount -= GlobalShop.shopValue;
        GlobalShop.shopValue *= 2;
        GlobalShop.turnOffButton = true;
        GlobalShop.shopPerSec += 1;
        GlobalShop.numberOfShops += 1;
    }

}
