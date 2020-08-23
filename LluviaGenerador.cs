//Nombre del desarrollador: Julio Méndez Cárdenas
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo:
/*
 Este script se utilizara para generar lluvia de obstaculos aleatorios
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LluviaGenerador : MonoBehaviour
{
    public GameObject Meteoros;
    public float tiempoCreacion = 1f;
    public float RangoCreacion = 2f;
    // Start is called before the first frame update
    void Start()
    {
        //tiempo para que se empiecen a generar
        InvokeRepeating("Creado", 2f, tiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Creado()
    {
       
        Vector3 SpawnPosition = new Vector3(0, 0, 0);
        //rango y lugares aleatorios que apareceran
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        //posicion donde se generaran los obstaculos
        SpawnPosition = new Vector3(SpawnPosition.x, this.transform.position.y, 1);

        GameObject Meteoro = Instantiate(Meteoros, SpawnPosition, Quaternion.identity);  
    }
}
