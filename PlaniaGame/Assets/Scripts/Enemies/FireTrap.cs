using System.Collections;
using UnityEngine;

public class FireTrap : MonoBehaviour
{
    [SerializeField] private float damage;

    [Header("FireTrap Timers")]
    [SerializeField] private float activationDelay;
    [SerializeField] private float activateTime;
    private Animator anim;
    private SpriteRenderer spriteRend;

    private bool triggered;
    private bool active;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!triggered)
                StartCoroutine(ActivateFiretrap());

            if (active)
                collision.GetComponent<Health>().TakeDamage(damage);
        }
    }

    private IEnumerator ActivateFiretrap()
    {
        triggered = true;
        spriteRend.color = Color.red; //vuelve al sprite rojo para que entienda el jugador
        
       //espera el delay, activa trampa, enciende animacion, vuelve a la normalidad el color
        
       yield return new WaitForSeconds(activationDelay);
        spriteRend.color = Color.white; //vuelve a lo normal
        active = true;
        anim.SetBool("activated", true);

        //espera ciertos segundos, desactiva trampa y resetea todas las variables y animaciones
        yield return new WaitForSeconds(activationDelay);
        active = false;
        triggered = false;
        anim.SetBool("activated", false);
    }
}
