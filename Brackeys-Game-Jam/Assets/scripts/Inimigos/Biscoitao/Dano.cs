using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dano : MonoBehaviour
{
    public int dano = 2;
    private Playervida playervida;

    void Start()
    {
        // Procura pelo Player usando a tag
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            playervida = player.GetComponent<Playervida>();
        }
        else
        {
            Debug.LogError("Nenhum objeto com tag 'Player' encontrado na cena!");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && playervida != null)
        {
            playervida.TomarDano(dano);
        }
    }
}
