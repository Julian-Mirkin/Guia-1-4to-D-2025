using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estacionamiento : MonoBehaviour
{

    public int hora;
    bool abierto;
    // Start is called before the first frame update
    void Start()
    {
        if(hora < 0 || hora > 24)
        {
            Debug.Log("Ha ingresado una hora incorrecta");
            return;
        } else
        {
            if (hora >= 10 && hora < 18)
            {
                abierto = true;
            }
            else
            {
                abierto = false;
            }
        }
        Debug.Log("El estacionamiento está abierto: " + abierto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
