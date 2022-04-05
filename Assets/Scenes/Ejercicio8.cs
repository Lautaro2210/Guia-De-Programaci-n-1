using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    // Start is called before the first frame update
    public int dia = 0;
    void Start()
    {
        switch (dia)
        {
            case 1: Debug.Log("Domingo");
                    break;      
            case 2: Debug.Log("lunes");
                    break;
            case 3: Debug.Log("martes");
                    break;      
            case 4: Debug.Log("miercoles");
                    break;      
            case 5: Debug.Log("jueves");
                    break;     
            case 6: Debug.Log("viernes");
                    break;     
            case 7: Debug.Log("sabado");
                    break;    
            default: Debug.Log("Su dia no corresponde");
                    break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
