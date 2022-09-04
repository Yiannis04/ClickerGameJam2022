using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DisasterScript : MonoBehaviour
{
    
    public GameObject statusBox; 
    public float appleCheck; 
    public int genChance; 
    public bool disasterActive = false;
    public int appleLoss; 

    // Update is called once per frame
    void Update()
    {
        appleCheck = GlobalApples.AppleCount / 10;
        if (disasterActive == false)
        {
            {
                StartCoroutine(StartDisaster());
            }
        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true; 
        genChance = Random.Range(1, 20);
        if (appleCheck >= genChance)
        {
            appleLoss = Mathf.RoundToInt(GlobalApples.AppleCount * 0.25f);
            statusBox.GetComponent<Text>().text = "Someone stole " + appleLoss + " apples";
            GlobalApples.AppleCount -= appleLoss;
            yield return new WaitForSeconds(3);
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        disasterActive = false;
    }
}
