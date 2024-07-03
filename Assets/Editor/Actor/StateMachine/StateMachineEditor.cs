using UnityEditor;

[CustomEditor(typeof(StateMachine), true)]
public class StateMachineEditor : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
        serializedObject.Update();
        StateMachine obj = (StateMachine)target;

        EditorGUILayout.TextField("Current State: ",
            obj.CurState == null ? "No state" : obj.CurState.name);

        serializedObject.ApplyModifiedProperties();
    }
}