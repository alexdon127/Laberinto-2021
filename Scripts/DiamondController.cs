using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondController : MonoBehaviour
{
    public GameObject gameController;
    public GameObject D1, D2, D3, D4, D5, D6, D7, D8, Ll;
    [SerializeField]
    private CanvasController canvas;

    void Start()
    {
        //Metodos para poder acceder tanto al GameController como al Canvas
        gameController = GameObject.FindGameObjectWithTag("GameController");
        canvas = FindObjectOfType<CanvasController>();
    }

    void Update()
    {

    }

    //Hacemos que si un collider entra en contacto con el collider del diamante reaccione
    void OnTriggerEnter(Collider other)
    {
        //Para que reaccione si es el collider del jugador
        if (other.tag == "Player")
        {
            //Si se trata del diamante numero 1, este se destuirá, aparecerá el icono de dicho diamante, sonará su correspondiente sonido y se sumará 1 al contador del PointController
            if (gameObject == D1)
            {
                Destroy(gameObject);
                canvas.PonerD1();
                gameController.SendMessage("SonarDiamante");
                PointController.contador = PointController.contador + 1;
                Debug.Log("FuncionaD");
                //Si contador es menor o igual que 7, aparecera un mensaje en la consola
                if (PointController.contador <= 7)
                {
                    Debug.Log("Has sumado el primero " + PointController.contador);
                }
                //Si contador es igual a 8, hará que aprezca la llave y pondra un mensaje en la consola
                else if (PointController.contador == 8)
                {
                    Ll.SetActive(true);
                    Debug.Log("Has sumado el primero y la llave");
                }
            }

            //Si se trata del diamante numero 2, este se destuirá, aparecerá el icono de dicho diamante, sonará su correspondiente sonido y se sumará 1 al contador del PointController
            if (gameObject == D2)
            {
                Destroy(gameObject);
                canvas.PonerD2();
                gameController.SendMessage("SonarDiamante"); 
                PointController.contador = PointController.contador + 1;
                Debug.Log("FuncionaD");
                //Si contador es menor o igual que 7, aparecera un mensaje en la consola
                if (PointController.contador <= 7)
                {
                    Debug.Log("Has sumado el segundo " + PointController.contador);
                }
                //Si contador es igual a 8, hará que aprezca la llave y pondra un mensaje en la consola
                else if (PointController.contador == 8)
                {
                    Ll.SetActive(true);
                    Debug.Log("Has sumado el segundo y la llave");
                }
            }

            //Si se trata del diamante numero 3, este se destuirá, aparecerá el icono de dicho diamante, sonará su correspondiente sonido y se sumará 1 al contador del PointController
            if (gameObject == D3)
            {
                Destroy(gameObject);
                canvas.PonerD3();
                gameController.SendMessage("SonarDiamante");
                PointController.contador = PointController.contador + 1;
                Debug.Log("FuncionaD");
                //Si contador es menor o igual que 7, aparecera un mensaje en la consola
                if (PointController.contador <= 7)
                {
                    Debug.Log("Has sumado el tercero " + PointController.contador);
                }
                //Si contador es igual a 8, hará que aprezca la llave y pondra un mensaje en la consola
                else if (PointController.contador == 8)
                {
                    Ll.SetActive(true);
                    Debug.Log("Has sumado el tercero y la llave");
                }
            }

            //Si se trata del diamante numero 4, este se destuirá, aparecerá el icono de dicho diamante, sonará su correspondiente sonido y se sumará 1 al contador del PointController
            if (gameObject == D4)
            {
                Destroy(gameObject); 
                canvas.PonerD4();
                gameController.SendMessage("SonarDiamante");
                PointController.contador = PointController.contador + 1;
                Debug.Log("FuncionaD");
                //Si contador es menor o igual que 7, aparecera un mensaje en la consola
                if (PointController.contador <= 7)
                {
                    Debug.Log("Has sumado el cuarto " + PointController.contador);
                }
                //Si contador es igual a 8, hará que aprezca la llave y pondra un mensaje en la consola
                else if (PointController.contador == 8)
                {
                    Ll.SetActive(true);
                    Debug.Log("Has sumado el cuarto y la llave");
                }
            }

            //Si se trata del diamante numero 5, este se destuirá, aparecerá el icono de dicho diamante, sonará su correspondiente sonido y se sumará 1 al contador del PointController
            if (gameObject == D5)
            {
                Destroy(gameObject);
                canvas.PonerD5();
                gameController.SendMessage("SonarDiamante");
                PointController.contador = PointController.contador + 1;
                Debug.Log("FuncionaD");
                //Si contador es menor o igual que 7, aparecera un mensaje en la consola
                if (PointController.contador <= 7)
                {
                    Debug.Log("Has sumado el quinto " + PointController.contador);
                }
                //Si contador es igual a 8, hará que aprezca la llave y pondra un mensaje en la consola
                else if (PointController.contador == 8)
                {
                    Ll.SetActive(true);
                    Debug.Log("Has sumado el quinto y la llave");
                }
            }

            //Si se trata del diamante numero 6, este se destuirá, aparecerá el icono de dicho diamante, sonará su correspondiente sonido y se sumará 1 al contador del PointController
            if (gameObject == D6)
            {
                Destroy(gameObject);
                canvas.PonerD6();
                gameController.SendMessage("SonarDiamante");
                PointController.contador = PointController.contador + 1;
                Debug.Log("FuncionaD");
                //Si contador es menor o igual que 7, aparecera un mensaje en la consola
                if (PointController.contador <= 7)
                {
                    Debug.Log("Has sumado el sexto " + PointController.contador);
                }
                //Si contador es igual a 8, hará que aprezca la llave y pondra un mensaje en la consola
                else if (PointController.contador == 8)
                {
                    Ll.SetActive(true);
                    Debug.Log("Has sumado el sexto y la llave");
                }
            }

            if (gameObject == D7)
            {
                Destroy(gameObject);
                canvas.PonerD7();
                gameController.SendMessage("SonarDiamante");
                PointController.contador = PointController.contador + 1;
                Debug.Log("FuncionaD");
                //Si contador es menor o igual que 7, aparecera un mensaje en la consola
                if (PointController.contador <= 7)
                {
                    Debug.Log("Has sumado el septimo " + PointController.contador);
                }
                //Si contador es igual a 8, hará que aprezca la llave y pondra un mensaje en la consola
                else if (PointController.contador == 8)
                {
                    Ll.SetActive(true);
                    Debug.Log("Has sumado el septimo y la llave");
                }
            }

            if (gameObject == D8)
            {
                Destroy(gameObject);
                canvas.PonerD8();
                gameController.SendMessage("SonarDiamante");
                PointController.contador = PointController.contador + 1;
                Debug.Log("FuncionaD");
                //Si contador es menor o igual que 7, aparecera un mensaje en la consola
                if (PointController.contador <= 7)
                {
                    Debug.Log("Has sumado el octavo " + PointController.contador);
                }
                //Si contador es igual a 8, hará que aprezca la llave y pondra un mensaje en la consola
                else if (PointController.contador == 8)
                {
                    Ll.SetActive(true);
                    Debug.Log("Has sumado el octavo y la llave");
                }
            }

            //Otra idea
            /*if (contador < 5){

                if (gameObject == D1){
                       canvas.PonerD1();
                       contador = contador + 1;
                    Debug.Log("Has sumado el primero " + contador);
                }
                else if (gameObject == D2){
                       canvas.PonerD2();
                    contador = contador + 1;
                    Debug.Log("Has sumado el segundo " + contador);
                }
                else if (gameObject == D3){
                       canvas.PonerD3();
                    contador = contador + 1;
                    Debug.Log("Has sumado el tercero" + contador);
                }
                else if (gameObject == D4){
                       canvas.PonerD4();
                    contador = contador + 1;
                    Debug.Log("Has sumado el cuarto" + contador);
                }
                else if (gameObject == D5){
                       canvas.PonerD5();
                    contador = contador + 1;
                    Debug.Log("Has sumado el quinto" + contador);
                }
                else if (gameObject == D6){
                       canvas.PonerD6();
                    contador = contador + 1;
                    Debug.Log("Has sumado el sexto" + contador);
                }
            }

            if (contador >= 5){

                if (gameObject == D1){
                       canvas.PonerD1();
                       Ll.SetActive(true);
                       Debug.Log("Has sumado el primero y la llave");
                }
                else if (gameObject == D2){
                       canvas.PonerD2();
                       Ll.SetActive(true);
                       Debug.Log("Has sumado el segundo y la llave");
                }
                else if (gameObject == D3){
                       canvas.PonerD3();
                       Ll.SetActive(true); 
                       Debug.Log("Has sumado el tercero y la llave");
                }
                else if (gameObject == D4){
                       canvas.PonerD4();
                       Ll.SetActive(true); 
                       Debug.Log("Has sumado el cuarto y la llave");
                }
                else if (gameObject == D5){
                       canvas.PonerD5();
                       Ll.SetActive(true);
                       Debug.Log("Has sumado el quinto y la llave");
                }
                else if (gameObject == D6){
                       canvas.PonerD6();
                       Ll.SetActive(true);
                       Debug.Log("Has sumado el sexto y la llave");
                } 
            }

            gameController.SendMessage("SonarDiamante");
            Debug.Log("FuncionaD");
            Destroy(gameObject);*/
        }

    }
}
