//Nombre del desarrollador: Julio Méndez Cárdenas
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo:
/*
 Este script se utilizara para quitar vida al player al colisionar
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    //para llamar a otro codigo
    [SerializeField]
    Controlador playerVida;
    void Start()
    {
        //Busca a un Game Onject con la etiqueta player
        playerVida = GameObject.FindGameObjectWithTag("Player").GetComponent<Controlador>();
    }    
    private void OnCollisionEnter2D (Collision2D collision)
    {
        //al dueño de la etiqueta player al colisionar pasara lo siguiente
        if (collision.gameObject.tag=="Player")
        {
            //reduce la cantidad de vida del player
            playerVida.vida--;
            //Destroy(collision.gameObject);
        }
    }
}
