using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultChecker : MonoBehaviour
{
    public int TotalNumber;
    int Current = 0;
    public GameObject TurnON;

    public void AddCountAndCheck()
    {
        Current++;
        if(Current==TotalNumber)
        {
            TurnON.SetActive(true);
        }
        Debug.Log(Current);
        
    }
}
