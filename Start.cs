//Nombre del desarrollador: Julio Méndez Cárdenas
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo:
/*
 Este script se utilizara para generar el menu
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    //para cambiar de una escena a otra 
    public void EscenaJuego()
    {
        //para que busque la escena con ese nombre
        SceneManager.LoadScene("Cubito_Videogame");
    }

}
