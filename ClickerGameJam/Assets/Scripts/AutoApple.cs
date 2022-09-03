using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoApple : MonoBehaviour
{

    public bool CreatingApple = false;
    public static int AppleIncrease = 1;
    public int InternalIncrease = 1; 

    // Update is called once per frame
    void Update()
    {
        InternalIncrease = AppleIncrease;
        if (CreatingApple == false)
        {
            CreatingApple = true; 
            StartCoroutine(CreateTheApple());
        }
    }

    IEnumerator CreateTheApple ()
    {
        GlobalApples.AppleCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingApple = false;
    }
}
