using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalPicker : MonoBehaviour
{

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int pickerValue = 50;
    public static bool turnOffButton = false;
    public GameObject pickerStats;
    public static int numberOfPickers; 
    public static int pickPerSec;
    

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount; 
        pickerStats.GetComponent<Text>().text = "Pickers: " + numberOfPickers + " picking " + pickPerSec + " Apples Per Second";
        fakeText.GetComponent<Text>().text = "Buy Picker - $" + pickerValue; 
        realText.GetComponent<Text>().text = "Buy Picker - $" + pickerValue;
        if (currentCash >= pickerValue)
        {
            fakeButton.SetActive(false); 
            realButton.SetActive(true);
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
