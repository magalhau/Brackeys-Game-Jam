using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinhos : MonoBehaviour
{
    public int danoespinho = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Goomba"))
        {
            Inimigovida inimigovida = collision.gameObject.GetComponent<Inimigovida>();

            if (inimigovida != null)
            {
                inimigovida.TomarDano(danoespinho);
            }
        }
    }
}
