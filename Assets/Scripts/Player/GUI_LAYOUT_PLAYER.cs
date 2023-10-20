using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



[CustomEditor(typeof(Movements))]
public class GUI_LAYOUT_PLAYER : Editor
{
    public override void OnInspectorGUI()
    {
        
        Movements moves = (Movements)target;
      //  moves.speed = EditorGUILayout.Slider("Speed",moves.speed, 100.0f, 500.0f);
        base.OnInspectorGUI();
    }
}
