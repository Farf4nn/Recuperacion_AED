using System;
using UnityEngine;

[Serializable]
public class Personaje
{
    public string nombre;
    public string quehace;
    public int speed;
    public int health;


    public Personaje(string nombre, string quehace, int speed, int health)
    {
        this.nombre = nombre;
        this.quehace = quehace;
        this.speed = speed;
        this.health = health;
    }
}
