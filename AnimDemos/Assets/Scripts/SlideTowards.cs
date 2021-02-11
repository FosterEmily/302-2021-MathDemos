using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideTowards : MonoBehaviour
{
    public Transform target;

    private Camera cam;

    private void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    void Update()
    {


        //slide the position towards the target
        transform.position = AnimMath.Slide(transform.position, target.position, .01f);

        //ease camera rotate to look at target

        Vector3 vectorToTarget = target.position - cam.transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);

        cam.transform.rotation = AnimMath.Slide(cam.transform.rotation, targetRotation, .05f);
    
    
    
    }
}
