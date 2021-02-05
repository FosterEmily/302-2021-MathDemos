using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LineRenderer))]
public class GenerateRingPath : MonoBehaviour
{
    [Range(10, 60)] public int num = 10;
    [Range(3, 20)] public float radius = 5;
    LineRenderer line;



    void Start()
    {
        GenratePath();

    }

   void OnValidate()
    {
        GenratePath();
    }
   private void GenratePath()
        {
            line = GetComponent<LineRenderer>();

            float rad = 0;

            Vector3[] pts = new Vector3[num];

            for (int i = 0; i < num; i++)
            {

                pts[i] = new Vector3(Mathf.Cos(rad), 0, Mathf.Sin(rad)) * radius + transform.position;
                rad += Mathf.PI * 2 / num;

            }
            line.positionCount = num;
            line.SetPositions(pts);
        }


    // Update is called once per frame
    void Update()
    {
        



    }
}
