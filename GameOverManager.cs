//Nombre del desarrollador: Julio Méndez Cárdenas
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo:
/*
 Este script se utilizara para poner letrero wasted al morir
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverManager : MonoBehaviour
{
    public static GameOverManager gameOverManager;
    public GameObject GameOver;
            
    // Start is called before the first frame update
    void Start()
    {
        //Iicializamos el letrero como apagado o invisible
        gameOverManager = this;
        GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //llamar a game over
    public void CallGameOver()
    {
        //true activa o vuelve visible el elemento que es el letrero wasted
        GameOver.SetActive(true);
    }
}
