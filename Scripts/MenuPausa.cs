using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public GameObject PanelP;
    private Reloj reloj;

    void Start()
    {
        reloj = FindObjectOfType<Reloj>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PanelP.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
            reloj.Pausar();
        }
    }
}
