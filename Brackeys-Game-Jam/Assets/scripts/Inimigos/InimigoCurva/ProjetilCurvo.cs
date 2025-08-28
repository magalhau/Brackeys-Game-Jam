using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoCurva : MonoBehaviour
{
    [Header("Configurações de Disparo")]
    public GameObject projetilCurva;   
    public Transform pontoDisparo;    
    public float forcaFrente = 10f;   
    public float forcaCurva = 5f;      
    public float intervaloTiro = 2f;   

    private void Start()
    {
        // loop de tiros
        StartCoroutine(AtirarEmLoop());
    }

    IEnumerator AtirarEmLoop()
    {
        while (true)
        {
            Atirar();
            yield return new WaitForSeconds(intervaloTiro);
        }
    }

    void Atirar()
    {
        if (projetilCurva != null && pontoDisparo != null)
        {
            
            GameObject projetil = Instantiate(projetilCurva, pontoDisparo.position, pontoDisparo.rotation);

            // frente e curva
            Rigidbody2D rb = projetil.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.AddForce(pontoDisparo.right * forcaFrente, ForceMode2D.Impulse);
                rb.AddForce(pontoDisparo.up * forcaCurva, ForceMode2D.Impulse);
            }
        }
    }
}
