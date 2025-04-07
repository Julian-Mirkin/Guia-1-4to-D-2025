using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba2 : MonoBehaviour
{
    public string categoriaAnimal;
    public int diasAQuedarse;

    int gramosPorDiaGato = 300;
    int gramosPorDiaPerroP = 400;
    int gramosPorDiaPerroG = 700;

    int gramosPorDiaAnimal;
    float gramosNecesitados;
    

    // Start is called before the first frame update
    void Start()
    {
        if (categoriaAnimal == gato)
        {
            gramosPorDiaAnimal = gramosPorDiaGato;
            gramosNecesitados = gramosPorDiaAnimal * diasAQuedarse;
            Debug.Log("Para este período se necesitan " + )
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
