using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Mouse
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("button presed");
        }
        if (Input.GetMouseButton(0)) {
            Debug.Log("button is pressed");
        }
        if (Input.GetMouseButtonUp(0)) {
            Debug.Log("button released");
        }

        //1.1 GetMouseButton(0) se puede cambiar por 1
        // 0 = boton izquierdo del mouse
        // 1 = boton derecho del mouse

        //Generar eventon con teclado
        if(Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Usando KeyCode. Puedes usar esto para hacer que el jugador salte");
        }

        if(Input.GetButtonDown("Jump")){
            Debug.Log("Usando Jump. puedes hacer saltar al jugador");
        }

        //3.- axis de movimientos
        float horizontal = Input.GetAxis("Horizontal"); // -1 a 1
        float vertical = Input.GetAxis("Vertical"); // -1 to 1

        if (horizontal < 0f || horizontal > 0f) {
            Debug.Log("Horizontal axis is" + horizontal);
        }
        if (vertical < 0f || vertical > 0f) {
            Debug.Log("Vertical axis is" + vertical);
        }
    }
}
