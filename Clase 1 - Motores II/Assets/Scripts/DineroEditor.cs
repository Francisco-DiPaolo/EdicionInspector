using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Dinero))]
public class DineroEditor : Editor
{

    public override void OnInspectorGUI()
    {

        Dinero dinero = (Dinero)target;

        if (GUILayout.Button("Generar Dinero"))
        {
            //Debug.Log("Dar Plata");

            dinero.SumarDinero();

            dinero.animator.Play("FadeIn");
        }
    }
}
