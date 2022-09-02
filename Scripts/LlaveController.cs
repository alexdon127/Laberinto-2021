using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveController : MonoBehaviour
{
    public GameObject gameController, Pared;
    public Vector3 rotationAngle;
    public float rotationSpeed;
    [SerializeField]
    private CanvasController canvas;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        canvas = FindObjectOfType<CanvasController>();
    }

    void Update()
    {
        transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameController.SendMessage("SonarLlave");
            Pared.SetActive(false);
            canvas.PonerLl();
            Debug.Log("FuncionaLL");
            Destroy(gameObject);
        }

    }
}