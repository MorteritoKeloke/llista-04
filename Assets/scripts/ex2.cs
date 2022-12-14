using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    public float cm;
    void Start()
    {
        CmToIches(cm);
    }
    //here we only use the centimeters to inches conversion formula
    private float CmToIches(float cm)
    { 
        float inches=cm * 0.39370f;
        Debug.Log($"{cm} cm is {inches} inches");
        return inches;
    }
}
