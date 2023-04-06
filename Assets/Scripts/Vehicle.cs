using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Ejercicio: Crea variables
    [SerializeField] private int wheels = 4; //Number of wheels of the vehicle
    
    // Ejercicio: Muestra variables I
    [SerializeField] private string name;
    
    // Ejercicio: Arrancar el vehículo I.I
    [SerializeField] private bool isOn;
    
    // Ejercicio: Arrancar el vehículo III.I
    public string sound;

    // Ejercicio: Gasolina suficiente I.I
    [SerializeField] private float gasoline;
    
    // Ejercicio: Aumento de tamaño I
    public bool canGetBigger;
    
    private void Start()
    {
        // Ejercicio: Muestra variables II
        // * Forma 1
        Debug.Log($"El vehículo {name} tiene {wheels} ruedas.");
        // * Forma 2
        // Debug.Log(string.Format("El vehículo {0} tiene {1} ruedas.", name, wheels));
        // * Forma 3
        // Debug.Log("El vehículo " + name + " tiene " + wheels + " ruedas");
        
        /*
        // Ejercicio: Arrancar el vehículo I.II
        if (isOn)
        {
            Debug.Log($"El vechículo {name} está encendido");
        }
        else // Ejercicio: Arrancar el vehículo II
        {
            Debug.Log($"El vechículo {name} está apagado");
        }
        */

        /*
        // Ejercicio: Arrancar el vehículo III.II
        if (isOn == false) 
        {
            Debug.Log($"El vechículo {name} está apagado");
        }
        else if (sound != "")
        {
            Debug.Log($"El vechículo {name} está encendido y hace {sound}");
        }
        else
        {
            Debug.Log($"El vechículo {name} está en marcha");
        }
        */
        
        /*
        // Ejercicio: Gasolina suficiente I.II
        if (isOn)
        {
            if (gasoline < 10)
            {
                Debug.Log($"¡A {name} le queda poca gasolina!");
            }
        }
        */
        
        // Ejercicio: Gasolina suficiente II
        if (isOn && gasoline < 10)
        {
            Debug.Log($"¡A {name} le queda poca gasolina!");
        }
    }

    // Ejercicio: Aumento de tamaño II
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale += Vector3.one;
        }
    }
}
