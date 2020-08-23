//Nombre del desarrollador: Julio Méndez Cárdenas
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo:
/*
 Este script se utilizara para limitar el desplazamiento del avatar jugador
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite : MonoBehaviour
{
    private Transform limite;
    //las variables publicas para modificarlas en el inspector desde UNITY 
    public Vector2 RangoH = Vector2.zero;
    public Vector2 RangoV = Vector2.zero;

    void LateUpdate()
    {
        //limitar el desplazamiento del jugador 
        limite.position = new Vector3
            //para el movimiento en x, y y z
                   (Mathf.Clamp(transform.position.x, RangoV.x, RangoV.y),
                   Mathf.Clamp(transform.position.y, RangoH.x, RangoH.y),
                   transform.position.z
                   );
    }

    // Start is called before the first frame update
    void Start()
    {
        //el limite llamara al componente transform para ejecutarse 
         limite = GetComponent<Transform>();
    }

}
