//Nombre del desarrollador: Julio Méndez Cárdenas
//Asignatura: Estructura de datos
//Descripcion del uso de este codigo:
/*
 Este script se utilizara para generar el control del avatar jugador
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{//INICIO del cuerpo de la clase

    //Area de declaracion de variables 
    public int vida;
    [SerializeField]
    float velocidadPersonaje;
    //public SpriteRenderer spritePlayer;
   
    // Start is called before the first frame update
    void Start()
    //Area de inializacion
    {
        //valor inicial de vida y vleocidad
        velocidadPersonaje = 10.0f;
        vida = 1;
    }

    // Update is called once per frame
    void Update()
    //Area de uso de variables 
    {
        //los codigos if son para realizar las mecanicas de desplazamiento sin rigidbody
        //Lo que activa la mecanica es la tecla rigth arrow (flecha de la derecha)
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Movimiento a la derecha 
            transform.position += Vector3.right * velocidadPersonaje * Time.deltaTime;
        }
        //Get Key condicioina que mientras se presione la tecla en este caso flecha a la izquierda ejecute la accion 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Movimiento a la izquierda 
            transform.position += Vector3.left * velocidadPersonaje * Time.deltaTime;
        }
        //La entrada es la tecla de la flecha hacia arriba 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Movimiento hacia arriba
            transform.position += Vector3.up * velocidadPersonaje * Time.deltaTime;
        }
        //La entrada que permite llevar a cabo la accion es la flecha hacia abajo del teclado
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Movimiento hacia abajo
            transform.position += Vector3.down * velocidadPersonaje * Time.deltaTime;
        }
        //Condicion de si la vida llega a ser 0 o menor que 0 muere el personaje 
        if (vida <= 0)
        {
            //Cuando se cumpla la condicion se destrulle el elemento que tenga este codigo 
            //Destroy(this.gameObject);
            //cuando muera el personaje no se va a poder mover pero seguira en pantalla
            velocidadPersonaje = 0;
            //al morir aparecera el letrero de game object
            GameOverManager.gameOverManager.CallGameOver();
        }
    }
}//FIN del cuerpo
