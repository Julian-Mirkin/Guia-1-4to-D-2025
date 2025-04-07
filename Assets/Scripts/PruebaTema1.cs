using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaTema1 : MonoBehaviour
{
    public float monto;
    public string moneda;

    float montoMinimoAConvertir = 1000;

    // Start is called before the first frame update
    void Start()
    {
        if (monto < montoMinimoAConvertir)
        {
            Debug.Log("El monto mínimo es 1000");
        }
        else if(moneda != "D" && moneda != "R" && moneda != "E")
        {
            Debug.Log("Opción de moneda extranjera no válida");
        } else
        {
            if (moneda == "D")
            {
                Debug.Log("Su monto en DOLARES es: $" + monto * 1300);
            } else if (moneda == "R")
            {
                Debug.Log("Su monto en REALES es: $" + monto * 180);
            } else
            {
                Debug.Log("Su monto en EUROS es: $" + monto * 1175);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
