using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ExamenVariables : MonoBehaviour
{
    [Header("Variables Ejercicio")]
    public int tortas = 15;
    public int hamburguesas = 23;

    public float refrescos = 30.5f;
    public float jugos = 24.5f;

    private bool tieneHambre;
    private string comida = "pizza";
    private string sabor = "peperoni";
    private string tipoPizza;
    private int comidaTotal;
    private int comidaRestante;
    private int comidaIngerida = 30;
    private float personas = 9f;
    private float cantidadPorPersona;
    private float gastoTotal;
    private float precioDeBebidas = 25f;

    [Header("Variables Historia")]
    public int meses = 2;
    public string cafeina = "cafeína";
    public string amsiedad = "ansiedad";
    private float precioPre = 30f;
    private float precioAgua = 20f;
    private int cantidadPre = 390;
    private int cantidadPre2 = 760;
    private float precioTotal;

    private void Start()
    {
        //Suma
      comidaTotal  = tortas + hamburguesas;
      Debug.Log("La suma de las tortas y las hamburguesas es igual a " + comidaTotal);

        //Resta
      comidaRestante = comidaTotal - comidaIngerida;
      Debug.Log("La comida sobrante es igual a " + comidaRestante);

        //Multiplicacion
      gastoTotal = refrescos + jugos * precioDeBebidas;
        Debug.Log("El gasto total de refrescos es igual a " + gastoTotal);
      
        //Division
      cantidadPorPersona = refrescos + jugos / personas;
        Debug.Log("Cantidad de bebida por persona es igual a " + cantidadPorPersona);

        //Concatenar
        tipoPizza = comida + " de " + sabor;
        Debug.Log(tipoPizza);

        //Anecdota
        
        Debug.Log("Hace un tiempo, alrededor de " + meses + " meses en un entrenamiento en el gimnasio decidí tomar pre entreno," +
            " un suplemento que incrementa el rendimiento físico, aumenta la energía, mejora la concentración y retrasa " +
            "el cansancio muscular es decir, es como un bidón del fortnite, pero para lograr estos efectos contiene una " +
            "cantidad muy elevada de " + cafeina + "aunque claramente hay unos pre entrenos más cargados de cafeína que otros.");

        Debug.Log("Yo soy alguien muy ansioso por lo que mi relación con la cafeína no es muy buena, me produce un nivel de " + amsiedad + 
            " alto además, de vómito y diarrea pero muy de vez en cuando solo tomarlo para rendir mis entrenamientos aunque solo lo hago " +
            "cuando es temprano ya que si lo tomo en la tarde o noche no puedo dormir. ");

        precioTotal = precioTotal + precioPre;

        Debug.Log("Con todo este contexto ahora si viene la historia llegue al gimnasio decidí comprar un  scoop de pre entreno y una agua " +
            "para pasarmelo que fueron en total $"  + precioTotal + " pesos, este pre entreno contiene " + cantidadPre + "mg de " + cafeina + " lo cual es una locura, empecé mi entrenamiento" +
            " y todo iba bien hasta que sentí todo el golpe de la cafeína en menos de 5 minutos además conforme pasaba el entrenamiento cada vez subía mi" + amsiedad +
            " y mis ganas de vomitar a tal punto en que tuve que salir a la calle sentarme en la banqueta y tratar de relajar mi mente,");

        Debug.Log("ese dia detuve mi entrenamiento y cuando le conté a la persona de recepción lo que me sucedió esté me dijo que en el otro" +
            " gimnasio le había sobrado mucha cantidad de otro pre entreno por lo que decidió verter eso al bote del que yo tome pero el verdadero" +
            " problema es que ese pre entreno contiene " + cantidadPre + "mg de " + cafeina + " por lo que ese dia tuve el peor ataque de ansiedad en mi vida, a tal punto" +
            " de que ni siquiera podia hablar sentia un nudo tan grande en mi garganta que no podia hacerlo, no dormí nada y además vomite demasiado" +
            " en el transcurso de la noche y por esa razón no recomiendo tomar mucho ese suplemento si eres alguien ansioso o nervioso.");
      
      


    }
}
