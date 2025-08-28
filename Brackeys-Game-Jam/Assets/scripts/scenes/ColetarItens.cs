using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;          

public class ColetarItens : MonoBehaviour
{
    [Header("Configuração de Contagem")]
    public int ossosColetados = 0;
    public int biscoitosColetados = 0;
    public int bolasColetadas = 0;

    [Header("Limites de Itens")]
    public int maxOssos = 12;
    public int maxBiscoitos = 3;
    public int maxBolas = 1;

    [Header("Referências UI")]
    public TMP_Text textoOssos;      
    public TMP_Text textoBiscoitos;  
    public TMP_Text textoBolas;      

    void Start()
    {
        AtualizarUI();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica a tag do item coletado
        if (other.CompareTag("Osso") && ossosColetados < maxOssos)
        {
            ossosColetados++;
            Destroy(other.gameObject);
            AtualizarUI();
        }
        else if (other.CompareTag("Biscoito") && biscoitosColetados < maxBiscoitos)
        {
            biscoitosColetados++;
            Destroy(other.gameObject);
            AtualizarUI();
        }
        else if (other.CompareTag("bola") && bolasColetadas < maxBolas)
        {
            bolasColetadas++;
            Destroy(other.gameObject);
            AtualizarUI();
        }
    }

    void AtualizarUI()
    {
        if (textoOssos != null)
            textoOssos.text = "Ossos: " + ossosColetados + " / " + maxOssos;

        if (textoBiscoitos != null)
            textoBiscoitos.text = "Biscoitos: " + biscoitosColetados + " / " + maxBiscoitos;

        if (textoBolas != null)
            textoBolas.text = "Bolas: " + bolasColetadas + " / " + maxBolas;
    }
}
