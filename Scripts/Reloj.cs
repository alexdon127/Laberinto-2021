using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reloj : MonoBehaviour
{
    [Tooltip("Tiempo iniciar en Segundos")]
    public int tiempoinicial;
    [Tooltip("Escala del Tiempo del Reloj")]
    [Range(-10.0f, 10.0f)]
    public float escalaDeTiempo = 1;

    private Text myText;
    private float TiempoFrameConTiempoScale = 0f;
    private float tiempoMostrarEnSegundos = 0F;
    private float escalaDeTiempoPausar, escalaDeTiempoInicial;
    private bool EstaPausado = false;
    private bool eventoTiempoCeroInvocado = false;

    public GameObject P1;

    void Start()
    {
        //Escala de Tiempo Original
        escalaDeTiempoInicial = escalaDeTiempo;
        myText = GetComponent<Text>();
        tiempoMostrarEnSegundos = tiempoinicial;
        ActualizarReloj(tiempoinicial);
        Pausar();
    }

    // Update is called once per frame
    void Update()
    {
        if (!EstaPausado)
        {
            TiempoFrameConTiempoScale = Time.deltaTime * escalaDeTiempo;
            tiempoMostrarEnSegundos += TiempoFrameConTiempoScale;
            ActualizarReloj(tiempoMostrarEnSegundos);
        }

    }
    public void ActualizarReloj(float tiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        //int milisegundos = 0;
        string textoDelReloj;

        if (tiempoEnSegundos <= 0 && !eventoTiempoCeroInvocado)
        {
            P1.SetActive(true);
            Time.timeScale = 0;
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;
        }
    

        if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;
        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;
        //milisegundos = (int)tiempoEnSegundos / 1000;
        textoDelReloj = minutos.ToString("00 ") + ":" + segundos.ToString(" 00 ");// + ":" + milisegundos.ToString(" 000");
        myText.text = textoDelReloj;
    }

    public void Pausar()
    {
        if (!EstaPausado)
        {
            EstaPausado = true;
            escalaDeTiempoPausar = escalaDeTiempo;
            escalaDeTiempo = 0;
        }
    }

    public void Continuar()
    {
        if (EstaPausado)
        {
            EstaPausado = false;
            escalaDeTiempo = escalaDeTiempoPausar;
        }
    }

    public void Reset()
    {
        //SceneManager.LoadScene("Laberinto");
        EstaPausado = false;
        escalaDeTiempo = escalaDeTiempoInicial;
        tiempoMostrarEnSegundos = tiempoinicial;
        ActualizarReloj(tiempoMostrarEnSegundos);
        //SceneManager.LoadScene("Laberinto");
    }
}