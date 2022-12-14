using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{
    public float maximY;
    public float minimY;
    public float velocityY;

    float movimentY;

    void Update()
    {
        MOVIMENTy = Input.GetAxis("vertical");

        transform.Translate(0, movimentY *Time.deltaTime * velocityY, 0);
        transform.position = new Vector3 (transform.position.x,Mathf.Clamp(transform.position.y,minimY,maximY), transform.position);
    }
}
