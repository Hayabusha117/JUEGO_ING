﻿//CHÁVEZ MAGAÑA MANUEL 
//PROYECTO ING COMPUTACION UNAM 
//FECHA: 28/03/2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour
{
    public GameObject CanvasPerder;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Perdiste()
    {
        CanvasPerder.SetActive(true);
        Time.timeScale = 0;
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }
}
