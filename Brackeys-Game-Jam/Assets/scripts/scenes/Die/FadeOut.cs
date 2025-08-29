using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    [Header("Configura��es de Fade")]
    [SerializeField] private Renderer objetoRenderer;
    [SerializeField] private Renderer spot;
    [SerializeField] private float duracao = 2f; // Tempo para o fade

    [Header("Bot�o que vai aparecer")]
    [SerializeField] private GameObject botao; // Bot�o a ser ativado depois do fade

    private void Start()
    {
        if (objetoRenderer != null && spot != null)
        {
            Color cor = objetoRenderer.material.color;
            cor.a = 0f; // Come�a invis�vel
            objetoRenderer.material.color = cor;

            Color corspot = spot.material.color;
            cor .a = 0f; // Come�a invis�vel
            spot.material.color = cor;
        }

        if (botao != null)
        {
            botao.SetActive(false); // Esconde o bot�o no in�cio
        }

        StartCoroutine(FazerFadeIn());
    }

    private System.Collections.IEnumerator FazerFadeIn()
    {
        float tempo = 0f;
        Color cor = objetoRenderer.material.color;
        Color corspot = spot.material.color;

        while (tempo < duracao)
        {
            tempo += Time.deltaTime;
            float alpha = Mathf.Lerp(0f, 1f, tempo / duracao);
            cor.a = alpha;
            objetoRenderer.material.color = cor;
            corspot.a = alpha;
            spot.material.color = corspot;
            yield return null;
        }

        cor.a = 1f;
        corspot.a = 1f;
        objetoRenderer.material.color = cor;
        spot.material.color = corspot;

        if (botao != null)
        {
            botao.SetActive(true); // Ativa o bot�o ap�s o fade
        }
    }
}
