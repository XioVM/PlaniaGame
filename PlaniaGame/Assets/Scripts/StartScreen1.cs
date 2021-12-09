using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreen1 : MonoBehaviour
{

    public GameObject StartScreen;
    public GameObject GameIntroExplication;
    public GameObject Button_Next;
    // Start is called before the first frame update
    void Start()
    {
        GameIntroExplication.SetActive(false);
    }

    public void GameIntroExplicationPanel()
    {
        GameIntroExplication.SetActive(true);
        StartScreen.SetActive(false);
        StartCoroutine(Reloj());
    }

    public void ChangeSceneAnimaticIntro()
    {
        SceneManager.LoadScene("GameIntro");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string frase = "Hola Katia, soy el comandante PepeGrillo, acaba de surgir una misión de extrema importancia en las Amazonas. Te asigné a ti ya que eres una agente bastante aventurera y valiente, sé que te irá bien. " +
        "Vas a llegar con tu equipo y te bajarás en un punto específico, tu misión, por ahora es recorrer las zonas para ver si hay civilizaciones peligrosas alrededor. " +
        "Al final de tu recorrido, debes buscar a tu equipo para poder volver a casa. " +
        "Para poder desplazarte, debes hacerlo con la flecha izquierda y derecha de tu teclado, tendrás un planeador, que te ayudará a desplazarte rápidamente y esquivar obstáculos.";
    public Text texto;

    IEnumerator Reloj()
    {
        foreach (char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.05f);
        }
        Button_Next.SetActive(true);
    }
}
