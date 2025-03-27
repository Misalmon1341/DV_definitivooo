using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Xml.Schema;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //variables entera
    private int vida;
    public int vidaa; 
    public int daño = 2;

    //variables con decimales
    public float pizza = 1.0f;
    public float invitados = 3.0f;
    private float pizzadividida;
    private float refrescos;
    private float refrescosTotales;

    // variable de texto
    public string username = "BOXYSAS";
    public string id = "2123234";
    public string jugador;
    // variable booleana 
    public bool interruptorArma;
    void Start()//Esto es un comentario
    {
        /*Esto es un comentario
         * sas
         * sus
         * sis
         * sos
         */
        Debug.Log("Hola papu");
        vidaa = 1;
        //SUMA
        vidaa = vidaa + 2;//vidaa++;
        vidaa = vidaa + 3;//vidaa =+ 3;
        int total = vidaa + daño; ;

        //RESTA
        vida--;
        daño =- 2;
        daño = total - vida;

        //DIVISION
        pizzadividida = pizza /invitados;
        //MULTIPLICACION
        refrescosTotales = refrescos * invitados;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && !interruptorArma)
        {
            interruptorArma = true;
        }
        else if (Input.GetKey(KeyCode.E) && interruptorArma)
        {
            interruptorArma = false;
        }

    }
}
