using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyObject", menuName = "Enemy")]
public class EnemyObject : ScriptableObject
{
    [SerializeField] private string nombre;
    [SerializeField] private int vida;
    [SerializeField] private string saludo;

    public string Nombre { get { return nombre; } }
    public int Vida { get { return vida; } }
    public string Saludo { get { return saludo; } }

    public void PrintData()
    {
        Debug.Log("Nombre: " + nombre);
        Debug.Log("Vida maxima: " + vida);
        Debug.Log(saludo);
    }
}
