//Nombre del desarrollador: Julio Méndez Cárdenas
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo:
/*
 Este script se utilizara para generar el movimiento de obstaculos a la derecha
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBala : MonoBehaviour
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
        //mover de izquierda a derecha
        transform.Translate(Vector2.right * movimiento * Time.deltaTime);
    }
}
