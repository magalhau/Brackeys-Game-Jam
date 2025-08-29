using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinalDeFase : MonoBehaviour
{
    [Header("Referências")]
    public BoxCollider2D rb;
    public ColetarItens coletarItens;   // Script do Player

    private bool triggerAtivado = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Vê se coletou todos os itens
            if (coletarItens.ossosColetados >= coletarItens.maxOssos &&
                coletarItens.biscoitosColetados >= coletarItens.maxBiscoitos &&
                coletarItens.bolasColetadas >= coletarItens.maxBolas)
            {
                Debug.Log("Trigger Final ativado. Esperando o Biscoitão...");
                triggerAtivado = false;
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                Debug.Log("Ainda faltam itens para prender o Biscoitão!");
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
