using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    public GameObject[] Prefabs; 
    private int Array;
    void Start()
    {
        RanFigure()
         }
     private void RanFigure()
    {
        Array = Random.Range(0, Prefabs.Length); 
    }
}
