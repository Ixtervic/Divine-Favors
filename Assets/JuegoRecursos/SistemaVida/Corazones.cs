using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Corazones : MonoBehaviour
{
    public List<Image> listacorazones;
    public GameObject corazonesPrefab;
    public VidaJugador vidaJugador;
    public int indexActual;
    public Sprite corazonLleno;
    public Sprite corazonVacio;

    private void Awake() 
    {
        vidaJugador.cambioVida.AddListener(CambiarCorazones);
    }

    private void CambiarCorazones(int vidaActual)
    {
        if(!listacorazones.Any())
        {
            CrearCorazones(vidaActual);
        }
        else
        {
            CambiarVida(vidaActual);
        }
    }

    private void CrearCorazones(int cantidadMaximaVida)
    {
        for(int i = 0; i < cantidadMaximaVida; i++)
        {
            GameObject corazon = Instantiate(corazonesPrefab, transform);
            listacorazones.Add(corazon.GetComponent<Image>());
        }

        indexActual = cantidadMaximaVida - 1;
    }
    private void CambiarVida(int vidaActual)
    {
        if(vidaActual <= indexActual)
        {
            QuitarCorazones(vidaActual);
        }
        else
        {
            AgregarCorazones(vidaActual);
        }
    }
    private void QuitarCorazones(int vidaActual)
    {
        for(int i = indexActual; i >= vidaActual; i--)
        {
            indexActual = i;
            listacorazones[indexActual].sprite = corazonVacio;
        }
    }
    private void AgregarCorazones(int vidaActual)
    {
        for(int i = indexActual; i < vidaActual; i++)
        {
            indexActual = i;
            listacorazones[indexActual].sprite = corazonLleno;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
