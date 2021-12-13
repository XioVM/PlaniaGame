using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Writingsound : MonoBehaviour
{
    public GameObject Button_Next;
    public AudioSource SFXWriting;
    // Start is called before the first frame update
    void Start()
    {
        SFXWriting.Play();
        StartCoroutine(Reloj());
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            StopAllCoroutines();
            texto.text = frase;
            SFXWriting.Stop();
            Button_Next.SetActive(true);

        }
    }

    string frase = "Hola Katia, soy el comandante PepeGrillo, acaba de surgir una misi�n de extrema importancia en las Amazonas. Te asign� a ti ya que eres una agente bastante aventurera y valiente, s� que te ir� bien. " +
        "Vas a llegar con tu equipo y te bajar�s en un punto espec�fico, tu misi�n, por ahora es recorrer las zonas para ver si hay civilizaciones peligrosas alrededor. " +
        "Al final de tu recorrido, debes buscar a tu equipo para poder volver a casa. " +
        "Para poder desplazarte, debes hacerlo con la flecha izquierda y derecha de tu teclado, con la barra espaciadora tendr�s un planeador, que te ayudar� a desplazarte r�pidamente y esquivar obst�culos.";
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
