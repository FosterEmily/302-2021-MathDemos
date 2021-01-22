using System.Collections;
using System.Collections.Generic;
using UnityEditor;


[CustomEditor(typeof(LerpDemo))]
public class LerpDemoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        LerpDemo lerper = (LerpDemo) target;
        
        if (GUILayout.Button("PLAY"))
                {
            lerper.PlayTweenAnim();
        }

    }
}
