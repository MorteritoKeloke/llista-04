using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
    private float limitX = 48f;
    private float limitZ = 10f;
    void Start()
    {
        RandomPosition(limitX,limitZ);
    }

    //Here we use the funtion that we use in the exercise of feeding the animals
     private Vector3 RandomPosition(float limitX, float limitZ)
    {
        float ranX = Random.Range(-limitX, limitX); 
        float ranZ = Random.Range(-limitZ, limitZ);
        Debug.Log($"The random position it's {ranX}, {ranZ}, 0");
        return new Vector3(ranX, ranZ, 0);
        
    }
}
