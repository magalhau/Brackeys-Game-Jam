using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarNoEixo : MonoBehaviour
{
    public float velocidadeRotacao = 100f; 

    void Update()
    {
        transform.Rotate(Vector3.forward * velocidadeRotacao * Time.deltaTime);
    }
}
