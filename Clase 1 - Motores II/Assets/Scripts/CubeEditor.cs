using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        // Para que reaccione al cubo que estoy tocando
        Cube cube = (Cube)target;

        GUILayout.BeginHorizontal();

            if(GUILayout.Button("Generate Color"))
            {
                //Debug.Log("We pressed generate color!");

                cube.GenerateColor();
            }

            if (GUILayout.Button("Reset"))
            {
                cube.Reset();
            }

        GUILayout.EndHorizontal();
    }
}
