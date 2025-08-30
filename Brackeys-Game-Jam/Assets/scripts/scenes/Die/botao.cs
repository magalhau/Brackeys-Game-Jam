using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botao : MonoBehaviour
{
    [SerializeField] private string nomeCenaJogo;
    public void ReiniciarJogo()
    {

        SceneManager.LoadScene(nomeCenaJogo);

    }
}