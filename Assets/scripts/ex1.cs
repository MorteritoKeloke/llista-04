using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    public float money;
    public float moneyBox;

    void Start()
    {
        moneyBank(money, moneyBox);
        
    }

    private void moneyBank(float money, float moneyBox)
    {
        moneyBox = money + moneyBox;
        Debug.Log($"you have {moneyBox} money in you box");
    }
}
