using UnityEngine;

public class NodoPersonaje
{
    public Personaje dato;
    public NodoPersonaje siguiente;
    public NodoPersonaje anterior;


    public NodoPersonaje(Personaje dato)
    {
        this.dato = dato;
        siguiente = null;
        anterior = null;
    }
}