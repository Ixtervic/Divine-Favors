using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danio : MonoBehaviour
{
    public int ptsdanio;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.TryGetComponent(out VidaJugador vidaJugador))
        {
            vidaJugador.TomarDanio(ptsdanio);
        }
    }
}
