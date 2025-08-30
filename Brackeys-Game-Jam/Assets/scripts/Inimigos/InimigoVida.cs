using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigovida : MonoBehaviour
{
    public int Vida;
    public int VidaMax = 1;

    void Start()
    {
        Vida = VidaMax;
    }

    public void TomarDano(int amount)
    {
        Vida -= amount;
        if (Vida <= 0)
        {
            Destroy(gameObject);
        }

    }

}
