using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Transactions;
using UnityEngine;

public class theWok : DatosEntidad
{
    // Start is called before the first frame update
    void Start()
    {
        //tenemos que sobreescribir todo lo que pertenezca a este concreto diferente del base aqui, porque los definimos en DatosEntidad
        test = "theWok";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
