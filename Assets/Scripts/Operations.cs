using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml;
using UnityEngine;

public class Operations : MonoBehaviour
{
    // Ejercicio: Realiza operaciones con números reales I
    public float x;
    public float y;

    /*
    // Ejercicio: Realiza operaciones con números enteros
    public int xInt;
    public int yInt;
    */

    private void Start()
    {
        /*
        // Ejercicio: Realiza operaciones con números reales II
        Debug.Log($"Sum: {x} + {y} = {x + y}");
        Debug.Log($"Subtraction: {x} - {y} = {x - y}");
        Debug.Log($"Product: {x} * {y} = {x * y}");
        Debug.Log($"Division: {x} / {y} = {x / y}");
        
        // Ejercicio: Realiza operaciones con números enteros II
        Debug.Log($"Module: {xInt} % {yInt} = {xInt % yInt}");
        */
        Calculator(x, y);

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Calculator(x, y);
        }
    }

    // Ejercicio: Función calculadora
    private void Calculator(float num1, float num2)
    {
        Debug.Log($"Sum: {num1} + {num2} = {num1 + num2}");
        Debug.Log($"Subtraction: {num1} - {num2} = {num1 - num2}");
        Debug.Log($"Product: {num1} * {num2} = {num1 * num2}");
        Debug.Log($"Division: {num1} / {num2} = {num1 / num2}");
    }

}
