using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    // Start is called before the first frame update
    public int num1 = 0;
    

    void Start()
    {
        int num2 = 2;
        if (num1 < 1)
        {
            Debug.Log("El numero es menor o igual a 0");
        }
        else if (num1 % num2 == 0)
        {
            Debug.Log("Su numero es par");
        }
        else
        {
            Debug.Log("su numero es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
