using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescerObjeto : MonoBehaviour
{
    public float velocidade = 2f; // velocidade da descida
    public float posicaoInicialY = 9f;
    public float posicaoFinalY = 1f;

    private Vector3 destino;

    void Start()
    {
        
        transform.position = new Vector3(transform.position.x, posicaoInicialY, transform.position.z);

       
        destino = new Vector3(transform.position.x, posicaoFinalY, transform.position.z);
    }

    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, destino, velocidade * Time.deltaTime);
    }
}

