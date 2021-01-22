using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveAround : MonoBehaviour
{

    public Transform target;

    public float radius = 2;
    private float age = 0;
 
    void Start()
    {
        
    }

   
    void Update()
    {

        age += Time.deltaTime;

        Vector3 offset = new Vector3();
        offset.x = Mathf.Sin(age) * radius;
        offset.z = Mathf.Cos(age) * radius;
        //math
      
        transform.position = target.position + offset;


    }
}
