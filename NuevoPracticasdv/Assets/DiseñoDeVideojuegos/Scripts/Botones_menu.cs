using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones_menu : MonoBehaviour
{
    public void CambiarEscena()
    {
        SceneManager.LoadScene("Casa");
    }
}
