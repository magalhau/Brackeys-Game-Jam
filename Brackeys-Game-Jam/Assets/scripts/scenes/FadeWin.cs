using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FadeInUI : MonoBehaviour
{
    [Header("Referências")]
    public Image imagem;   // UI Image dentro da Canvas
    public Button botao;   // UI Button dentro da Canvas

    [Header("Configurações")]
    public float duracaoFade = 2f;   // tempo do fade in
    public float delayBotao = 1f;    // tempo até o botão aparecer

    void Start()
    {
        // Começa invisível
        Color cor = imagem.color;
        cor.a = 0f;
        imagem.color = cor;

        // Botão começa desativado
        botao.gameObject.SetActive(false);

        // Inicia o fade
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        float tempo = 0f;
        Color cor = imagem.color;

        while (tempo < duracaoFade)
        {
            tempo += Time.deltaTime;
            cor.a = Mathf.Clamp01(tempo / duracaoFade);
            imagem.color = cor;
            yield return null;
        }

        // Espera um pouco antes de mostrar o botão
        yield return new WaitForSeconds(delayBotao);

        botao.gameObject.SetActive(true);
    }
}
