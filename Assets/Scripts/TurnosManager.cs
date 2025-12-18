using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class TurnosManager : MonoBehaviour
{
    void Start()
    {
        // por aca esto crea la lista doblemente enlazada
        ListaDoblePersonajes listaTurnos = new ListaDoblePersonajes();

        Personaje personaje = new Personaje("", "", 0, 0);

        listaTurnos.Agregar(new("Erwin", "no programa", 0, 10));
        listaTurnos.Agregar(new("Erwin", "sabe", 0, 15));
        listaTurnos.Agregar(new("Erwin", "entiende", 10, 20));
        listaTurnos.Agregar(new("Erwin", "esta aqui para ´pasar", 20, 20));

        //Se recorre la lista y elimina personajes (turnos)
        listaTurnos.RecorrerYEliminar();

        listaTurnos.RecorrerYEliminar2();
    }
    
    private void BubbleSort(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
            }
        }
    }
}
