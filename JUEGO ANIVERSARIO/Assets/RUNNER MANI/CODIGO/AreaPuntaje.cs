//CHÁVEZ MAGAÑA MANUEL 
//PROYECTO ING COMPUTACION UNAM 
//FECHA: 28/03/2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaPuntaje : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LogicaPuntaje.puntaje++;
    }
}
