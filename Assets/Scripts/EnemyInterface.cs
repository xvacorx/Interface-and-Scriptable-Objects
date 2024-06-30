using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPresentacion
{
    public void Accion();
}

public interface ITakeDamage
{
    public void TakeDamage(int damageToTake);
}
