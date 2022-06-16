using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPj : MonoBehaviour
{
    [SerializeField] private Nivel nivel;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < nivel.cantEnemigos; i++)
        {
            Instantiate(nivel.enemigo, nivel.posicion, Quaternion.identity);
        }
    }
}
