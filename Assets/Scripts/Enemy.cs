using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IPresentacion, ITakeDamage
{
    [SerializeField] private EnemyObject enemyData;
    private int currentVida;

    private void Start()
    {
        currentVida = enemyData.Vida;
    }

    public void Accion()
    {
        enemyData.PrintData();
    }

    public void TakeDamage(int damageToTake)
    {
        currentVida -= damageToTake;
        Debug.Log("Vida de " + enemyData.Nombre + ": " + currentVida);

        if (currentVida < 0)
            Destroy(gameObject);
    }
}
