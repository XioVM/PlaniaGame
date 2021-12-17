using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonReiniciar : MonoBehaviour
{
    public void ReiniciarOnClick()
    {
        SceneManager.LoadScene("Inicio");
    }

    //agregue el script en el boton, ese script lo arrastre a buttononclick, agregue el registroonclick. File, Build Settings y agregar las escenas donde estas y donde quieres ir. 
}
