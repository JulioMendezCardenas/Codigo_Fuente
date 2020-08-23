//Nombre del desarrollador: Julio Méndez Cárdenas
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo:
/*
 Este script se utilizara para rotar asteroides
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotar alrededor (punto por rotar/eje/angulo)
        //punto el mismo objeto
        //eje z 0 0 -1 que es back
        //la variable que declaramos
        transform.RotateAround(transform.position, Vector3.back,speed*Time.deltaTime);
    }
}
