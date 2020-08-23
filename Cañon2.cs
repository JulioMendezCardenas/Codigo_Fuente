//Nombre del desarrollador: Julio Méndez Cárdenas
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo:
 /*
  Este script se utilizara para controlar el cerebro de enemigos
  */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon2 : MonoBehaviour
{
    public Transform[] puntoDisaparo;
    public GameObject bala;
    private float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        //cada que el tiempo sea de 9 se generara la accion
        if (tiempo >= 9)
        {
            //llamaremos al prefab
            Instantiate(bala, puntoDisaparo[0].position, Quaternion.identity);
            Instantiate(bala, puntoDisaparo[1].position, Quaternion.identity);
            //al pasar la accion se reiniciara el conteo
            tiempo = 0;

        }
    }
}
