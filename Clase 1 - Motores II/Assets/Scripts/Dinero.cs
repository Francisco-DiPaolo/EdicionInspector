using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dinero : MonoBehaviour
{
    public Text textDinero;
    public Animator animator;
    private int count;

    void Start()
    {
        textDinero.text = "$0";
    }

    public void SumarDinero()
    {
        count += 150;

        textDinero.text = "$" + count.ToString();

        textDinero.gameObject.SetActive(true);
    }
}
