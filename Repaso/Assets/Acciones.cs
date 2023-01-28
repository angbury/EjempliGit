using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Acciones : MonoBehaviour
{
    public TextMeshProUGUI output, input;

    public GameObject ocultar, mostrar;

    public void MiFuncion()
    {
        output.text = input.text;
        ocultar.SetActive(false);
        mostrar.SetActive(true);
    }
}