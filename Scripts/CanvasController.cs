using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public GameObject D1, D2, D3, D4, D5,
        D6, D7, D8, Ll, PanelI, PanelM, MenuP, PanelF;
    private Reloj reloj;

    void Start()
    {
        reloj = FindObjectOfType<Reloj>();
        Cursor.visible = true;
    }


    void OnGUI()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Laberinto");
        reloj.Reset();
        Time.timeScale = 1;
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void PonerD1()
    {
        D1.SetActive(true);
    }

    public void PonerD2()
    {
        D2.SetActive(true);
    }

    public void PonerD3()
    {
        D3.SetActive(true);
    }

    public void PonerD4()
    {
        D4.SetActive(true);
    }

    public void PonerD5()
    {
        D5.SetActive(true);
    }

    public void PonerD6()
    {
        D6.SetActive(true);
    }

    public void PonerD7()
    {
        D7.SetActive(true);
    }

    public void PonerD8()
    {
        D8.SetActive(true);
    }

    public void PonerLl()
    {
        Ll.SetActive(true);
    }

    public void QuitarPanelI()
    {
        PanelI.SetActive(false);
        Cursor.visible = false;
        reloj.Continuar();
    }

    public void QuitarMenuP()
    {
        MenuP.SetActive(false);
        Cursor.visible = false;
        reloj.Continuar();
        Time.timeScale = 1;
    }
    public void PonerFinal()
    {
        PanelF.SetActive(true);
        Time.timeScale = 1;
        reloj.Pausar();
    }
}