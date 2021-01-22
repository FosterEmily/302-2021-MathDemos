using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(LerpDemo))]
public class LerpDemoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI(); // draws normal part of the editor...

        LerpDemo lerper = (LerpDemo)target;

        if (GUILayout.Button("PLAY"))
        {
            lerper.PlayTweenAnim();
        }
    }
}

