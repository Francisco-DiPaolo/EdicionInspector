using UnityEngine;
using UnityEditor;

public class ExampleWindows : EditorWindow
{
    //string myString = "Hello World";
    Color color;

    [MenuItem("Window/Colorizer")]
    public static void ShowWindow ()
    {
        GetWindow<ExampleWindows>("Colorizer");
    }

    void OnGUI ()
    {
        GUILayout.Label("Color the selected objects!", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        // myString = EditorGUILayout.TextField("Name", myString);

        if (GUILayout.Button("COLORIZE!"))
        {
            Colorize();

            //Debug.Log("Button was pressed");
        }
    }

    void Colorize()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                // Si utilizo con shared, me cambiara el material default completo.
                renderer.sharedMaterial.color = color;

                // Aca me cambiara el color del objeto en particular.
                // renderer.material.color = color;
            }
        }
    }
}
