using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil_reto : MonoBehaviour
{
    public float distanciaMaxima = 10f;

    private Vector2 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position;
    }

    void Update()
    {
        float distanciaPercorrida = Vector2.Distance(posicaoInicial, transform.position);

        if (distanciaPercorrida >= distanciaMaxima)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Quando colidir com algo, destruir
        Destroy(gameObject);
    }
}
