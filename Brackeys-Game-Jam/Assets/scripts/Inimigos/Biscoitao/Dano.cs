using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{
    
    public Playervida Playervida;
    public int dano = 2;

    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Playervida.TomarDano(dano);
        }
    }
}
