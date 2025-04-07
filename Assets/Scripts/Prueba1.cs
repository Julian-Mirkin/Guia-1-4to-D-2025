using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba1 : MonoBehaviour
{

    public float monto;
    public string moneda;
    float cotizacionMonedaElegida;

    float montoMinimoAConvertir = 1000;
    float montoConvertido;
    float cotizacionDolar = 1297.21f;
    float cotizacionEuro = 1621.3f;
    float cotizacionReal = 183.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (monto < montoMinimoAConvertir)
        {
            Debug.Log("El monto mínimo a invertir es $1000");
            return;
        }

        if (moneda != "D" && moneda != "R" && moneda != "E")
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }

        if (moneda == "E")
        {
            cotizacionMonedaElegida = cotizacionEuro;
        }
        else if (moneda == "D")
        {
            cotizacionMonedaElegida = cotizacionDolar;
        }
        else if (moneda == "R")
        {
            cotizacionMonedaElegida = cotizacionReal;
        }


            montoConvertido = monto / cotizacionMonedaElegida;

        Debug.Log("Su monto en " + moneda + " es: $" + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
