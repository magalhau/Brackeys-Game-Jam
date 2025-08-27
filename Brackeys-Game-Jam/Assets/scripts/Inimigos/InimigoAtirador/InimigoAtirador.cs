using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InimigoAtirador : MonoBehaviour
{
    public GameObject projetilPrefab;
    public Transform pontoDisparo;
    public float intervaloDisparo = 1.5f;
    public float velocidadeProjetil = 5f;
    public Vector2 direcaoTiro = Vector2.left; // Padrão: esquerda
    public Animator animator; // Arraste o Animator no Inspector
    public string animAtirando = "atirando_esquerda"; // Nome da animação

    private float tempoProximoTiro;

    void Update()
    {
        // Define se deve dar flip no sprite baseado na direção
        AtualizarFlip();

        // Dispara no intervalo definido
        if (Time.time >= tempoProximoTiro)
        {
            Atirar();
            tempoProximoTiro = Time.time + intervaloDisparo;
        }
    }

    void Atirar()
    {
        if (projetilPrefab == null)
        {
            Debug.LogError("ProjetilPrefab não está atribuído no Inspector!");
            return;
        }

        // Toca a animação sempre que atira
        if (animator != null)
        {
            animator.Play(animAtirando);
        }

        // Instancia o projétil
        GameObject projetil = Instantiate(projetilPrefab, pontoDisparo.position, Quaternion.identity);

        Rigidbody2D rb = projetil.GetComponent<Rigidbody2D>();
        rb.velocity = direcaoTiro.normalized * velocidadeProjetil;
    }

    void AtualizarFlip()
    {
        if (direcaoTiro.x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1); // Normal (esquerda)
        }
        else if (direcaoTiro.x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1); // Flip para direita
        }
    }
}
// (1, 0) → Direita

//(-1, 0) → Esquerda

//(0, 1) → Para cima

//(0, -1) → Para baixo