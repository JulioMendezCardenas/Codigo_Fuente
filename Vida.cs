//Nombre del desarrollador: Julio Méndez Cárdenas
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo:
/*
 Este script se utilizara para tiempo de vida de obstaculos
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float tiempoVida;
    // Start is called before the first frame update
    void Start()
    {
        //el tiempo de vida del obstaculo seran 3 para no saturar de basura
        tiempoVida =3f;
    }

    // Update is called once per frame
    void Update()
    {
        //cuando el tiempo pase se destruira el objeto
        Destroy(this.gameObject,tiempoVida);
    }
}
