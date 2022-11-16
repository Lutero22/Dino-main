using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public float Puntos;
    public float Aumento;
    public Text Puntuacion;
    void Start()
    {
        Puntos = 0f;
        Aumento = 30f;
    }

    void Update()
    {
        Puntuacion.text = (int)Puntos + "";
            Puntos += Aumento * Time.deltaTime;
    }
}
