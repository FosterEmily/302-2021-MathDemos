using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpBewtween2Points : MonoBehaviour
{

    public Transform positionA;
    public Transform positionB;

    public float percent;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = AnimMath.Lerp(positionA.position, positionB.position, percent);
    }
}
