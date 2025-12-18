using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
public class ListaDoblePersonajes
{
    private NodoPersonaje cabeza;
    private NodoPersonaje cola;

    public void Agregar(Personaje personaje)
    {
        NodoPersonaje nuevo = new NodoPersonaje(personaje);

        if (cabeza == null)
        {
            cabeza = cola = nuevo;
        }
        else
        {
            cola.siguiente = nuevo;
            nuevo.anterior = cola;
            cola = nuevo;
        }
    }

    public void RecorrerYEliminar()
    {
        NodoPersonaje actual = cabeza;

        while (actual != null)
        {
            Debug.Log("Turno de " + actual.dato.nombre + " | Accion: " + actual.dato.quehace + " | Velocidad: " + actual.dato.speed + " | Vida: " + actual.dato.health);


            NodoPersonaje siguiente = actual.siguiente;
            Eliminar(actual);
            actual = siguiente;
        }
    }
    public Personaje[] RecorrerYEliminar2()
    {
        NodoPersonaje actual = cabeza;

        Personaje[] listemp = new Personaje[3];
        for (int i = 0; i < 4; i++)
        {
            int array = actual.dato.speed;
            int n = array;
        }

        while (actual != null)
        {
            Debug.Log("Turno de " + actual.dato.nombre + " | Accion: " + actual.dato.quehace + " | Velocidad: " + actual.dato.speed + " | Vida: " + actual.dato.health);


            NodoPersonaje siguiente = actual.siguiente;
            Eliminar(actual);
            actual = siguiente;

        }
        return listemp;
    }

    private void Eliminar(NodoPersonaje nodo)
    {
        if (nodo.anterior != null)
            nodo.anterior.siguiente = nodo.siguiente;
        else
            cabeza = nodo.siguiente;


        if (nodo.siguiente != null)
            nodo.siguiente.anterior = nodo.anterior;
        else
            cola = nodo.anterior;

        nodo.siguiente = null;
        nodo.anterior = null;
    }
}
