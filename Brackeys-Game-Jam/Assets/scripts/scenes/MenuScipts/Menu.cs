using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private string nomeCenaJogo;
    [SerializeField] private GameObject PainelMenuInicial;
    [SerializeField] private GameObject PainelOpcoes;

    public void Jogar()
    {
        SceneManager.LoadScene(nomeCenaJogo);
        PainelOpcoes.SetActive(false);
    }

    public void opcoes()
    {
        PainelMenuInicial.SetActive(false);
        PainelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        PainelOpcoes.SetActive(false);
        PainelMenuInicial.SetActive(true);
    }

    public void Sair()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}