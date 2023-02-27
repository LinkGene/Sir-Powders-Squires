using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MF_Level_Functions))]
public class Inspector_MF_Level : Editor
{
    public override void OnInspectorGUI()
    {
        GUILayout.Label ("Press this to get more");
        
        MF_Level_Functions exam = (MF_Level_Functions)target;
        if(GUILayout.Button("Spawn Next Piece"))
        {
            exam.Spawn_Next_MF();
        }
        
        DrawDefaultInspector ();
    }
}