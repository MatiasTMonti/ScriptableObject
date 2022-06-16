using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Nivel")]

public class Nivel : ScriptableObject
{
    public GameObject enemigo;
    public int cantEnemigos;
    public Vector3 posicion;
}
