using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biscoitao : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Se o objeto tem a tag que você quer ignorar
        if (collision.gameObject.CompareTag("ItemIgnorado") || collision.gameObject.CompareTag("Goomba"))
        {
            // Pega o colisor do inimigo e do item
            Collider2D colisorInimigo = GetComponent<Collider2D>();
            Collider2D colisorItem = collision.collider;

            // Ignora colisão
            Physics2D.IgnoreCollision(colisorInimigo, colisorItem);
        }
    }
}