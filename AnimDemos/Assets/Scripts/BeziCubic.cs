using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BeziCubic : MonoBehaviour
{

    public Transform pointA;
    public Transform pointB;
    public Transform handle;

    public float percent;

    public int curveRes = 10;

    [Header("Tween Stuff")]
    [Tooltip("How long will the tween take")]
    [Range(.1f,10)] public float tweenLenght = 3;
    public AnimationCurve tweenSpeed;

    private float tweenTimer = 0;
    private bool isTweening = false;

    void Start()
    {
        
    }


    void Update()
    {


        if (isTweening)
        {
            tweenTimer += Time.deltaTime;
            float p = tweenTimer / tweenLenght;

            percent = tweenSpeed.Evaluate(p);

            if (tweenTimer > tweenLenght) isTweening = false;


        }

        transform.position = CalcPositionOnCurve(percent);


    }

    public void PlayTween()
    {
        tweenTimer = 0;
        isTweening = true;
    }

    private Vector3 CalcPositionOnCurve(float percent)
    {

        // position c = lerp between position a and handle

        Vector3 c = AnimMath.Lerp(pointA.position, handle.position, percent);
        Vector3 d = AnimMath.Lerp(handle.position, pointB.position, percent);

        Vector3 f = AnimMath.Lerp(c, d, percent);

        return f;

    }

    private void OnDrawGizmos()
    {

        Vector3 p1 = pointA.position;

        for(int i = 1; i< curveRes; i++)
        {

            float p = i / (float)curveRes;
           Vector3 p2 = CalcPositionOnCurve(p);

            Gizmos.DrawLine(p1, p2);
            p1 = p2;
        }
        Gizmos.DrawLine(p1, pointB.position);

    }


}


[CustomEditor(typeof(BeziCubic))]
public class BeziCubicEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

       if( GUILayout.Button("Play tween"))
        {

            (target as BeziCubic).PlayTween();

        }


    }

}
