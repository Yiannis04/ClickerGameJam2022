using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{

    public GameObject AutoApple; 


    public void StartAutoApple ()
    {
        AutoApple.SetActive(true);
        GlobalCash.CashCount -= GlobalPicker.pickerValue;
        GlobalPicker.pickerValue *= 2;
        GlobalPicker.turnOffButton = true;
    }

}
