using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalController : MonoBehaviour
{
    public GameObject gameController;
    [SerializeField]
    private CanvasController canvas;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        canvas = FindObjectOfType<CanvasController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.PonerFinal();
        }

    }
}
