using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curacion : MonoBehaviour
{
    public int ptsCuracion;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.TryGetComponent(out VidaJugador vidaJugador))
        {
            vidaJugador.CurarVida(ptsCuracion);
        }
    }
}
