using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BaseActor), true)]
public class BaseActorEditor : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
        serializedObject.Update();
        BaseActor obj = (BaseActor)target;

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("-----STATUS-------", EditorStyles.boldLabel);
        try {
            EditorGUILayout.TextField(nameof(obj.Is_Dead), obj.Is_Dead.ToString());
            EditorGUILayout.TextField(nameof(obj.Is_Have_Control_Request), obj.Is_Have_Control_Request.ToString());
            EditorGUILayout.TextField(nameof(obj.Is_Ready_To_Auto_Attack), obj.Is_Ready_To_Auto_Attack.ToString());
            EditorGUILayout.TextField(nameof(obj.Is_Ready_To_Auto_Follow), obj.Is_Ready_To_Auto_Follow.ToString());
        } catch { }
        //obj.canControll = EditorGUILayout.ToggleLeft(nameof(obj.canControll), obj.canControll);

        serializedObject.ApplyModifiedProperties();
    }
}