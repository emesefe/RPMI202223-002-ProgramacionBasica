using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
     This is a 
     multiline comment
    */
    
    /*
    // Declaración de variables y tipos de variables
    public int playerAge = 33;
    public string playerName = "emesefe";
    private float playerSpeed = 3.125f;
    [SerializeField] private bool isGameOver = false;


    // Mostrar mensajes por consola
    public string message = "Hola mundo.";
    public int points = 256;
    */

    
    /*
    // Operadores aritméticos
    public float x = 2;
    public float y = 3;
    private float result;
    public int xInt = 10;
    public int yInt = 4;
    public int resultInt;
    */
    
    /*
    // Operadores de decisión
    public bool isRaining;
    public float number; 
    */
    
    // Vectores
    public Vector3 initialPos = new Vector3 (1, 1, 1);
    public Vector3 subir = new Vector3(0, 1, 0);

    private void Start()
    {
        /*
        // Mostrar mensajes por consola
        // * De forma directa mostramos el resultado de una variable
        Debug.Log(message);
        Debug.Log(points);
        
        // * Combinamos strings con valores de variables
        // ** FORMA 1
        Debug.Log($"Tengo {points} puntos"); // Una sola variable
        Debug.Log($"Hola {playerName}, tienes {points} puntos"); // Más de una variable
        
        // ** FORMA 2
        Debug.Log(string.Format("Tengo {0} puntos", points)); // Una sola variable
        Debug.Log(string.Format("Hola {0}, tienes {1} puntos", 
            playerName, points)); // Más de una variable
        
        // ** FORMA 3
        Debug.Log("Tengo " + points + " puntos"); // Una sola variable
        Debug.Log("Hola " + playerName + " tienes " + points + " puntos"); // Más de una variable
        */
        
        
        // Operadores aritméticos
        // * Suma
        // ** Nos ayudamos de una variable adicional que guarda el resultado
        // result = x + y;
        // Debug.Log(result);
        // ** Modificamos directamente uno de los sumandos cada vez que llevamos a cabo la operación suma
        // *** Forma larga
        //x = x + y;
        // *** Forma vaga
        //x += y;
        // *** Caso particular en que sumamos de 1 en 1
        // x++;
        // Debug.Log(x);
        
        // * Resta
        // ** Nos ayudamos de una variable adicional que guarda el resultado
        // result = x - y;
        // Debug.Log(result);
        // ** Modificamos directamente el minuendo cada vez que llevamos a cabo la operación resta
        // *** Forma larga
        //x = x - y;
        // *** Forma vaga
        //x -= y;
        // *** Caso particular en que restamos de 1 en 1
        // x--;
        // Debug.Log(x);
        
        // * Multiplicación
        // ** Nos ayudamos de una variable adicional que guarda el resultado
        // result = x * y;
        // Debug.Log(result);
        // ** Modificamos directamente uno de los factores cada vez que llevamos a cabo la operación producto
        // *** Forma larga
        //x = x * y;
        // *** Forma vaga
        // x *= y;
        // Debug.Log(x);
        
        // * División
        // Es recomendable que las variables sean de tipo float
        // ** Nos ayudamos de una variable adicional que guarda el resultado
        // result = x / y;
        // Debug.Log(result);
        // ** Modificamos directamente el dividendo cada vez que llevamos a cabo la operación división
        // *** Forma larga
        //x = x / y;
        // *** Forma vaga
        //x /= y;
        //Debug.Log(x);
        
        // * Módulo: nos devuelve el resto de la división entera
        // Es importante que las variables sean de tipo int
        // ** Nos ayudamos de una variable adicional que guarda el resultado
        // resultInt = xInt % yInt;
        // Debug.Log(resultInt);
        // ** Modificamos directamente el dividendo cada vez que llevamos a cabo la operación módulo
        // *** Forma larga
        //xInt = xInt % yInt;
        // *** Forma vaga
        //xInt %= yInt;
        //Debug.Log(xInt);
        
        
        // Operadores condicionales
        // * Igualdad ==
        // * Desgualdad !=
        // * Mayor >
        // * Menor <
        // * Mayor o igual >=
        // * Menor o igual <=
        
        /*
        // Operadores de decisión
        if (isRaining == true) 
        {
            Debug.Log("Recuerda coger paraguas.");
        }

        if (number > 0)
        {
            Debug.Log("El número {number} es positivo.");
        }
        else
        {
            Debug.Log("El número {number} es negativo o cero");
        }
        */

        // Vectores
        //Debug.Log(transform.position); // Accedemos a la posición del Game Object
        //transform.position = initialPos; // Modificamos la posición del Game Object
        
        //transform.position += subir;
        //transform.position += subir;
        
        
      
        MySum(2, 3);
        MySum(5, 2);
        MySum(1, 0);
        MySum(10, 9);


    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Si hacemos click en el botón izquierdo del ratón
        {
            transform.position += subir;
        }
    }

    private int MySum(int x, int y)
    {
        int result = x + y;
        //Debug.Log(result);
        return result;
    }
}
    

