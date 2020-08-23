//Nombre del desarrollador: Julio Méndez Cárdenas
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo:
/*
 Este script se utilizara para generar el movimiento de obstaculos a la izquierda
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movnegativo : MonoBehaviour
{
    [SerializeField]
    float movimiento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mover de derecha a izuqierda
        transform.Translate(Vector2.left * movimiento * Time.deltaTime);
    }
}
