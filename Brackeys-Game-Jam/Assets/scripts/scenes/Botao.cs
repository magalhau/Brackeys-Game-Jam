using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botao : MonoBehaviour
{
    [SerializeField] private string nomeDaCena; // Nome da cena para carregar

    public void TrocarCena()
    {
        if (!string.IsNullOrEmpty(nomeDaCena))
        {
            SceneManager.LoadScene(nomeDaCena);
        }
        else
        {
            Debug.LogWarning("O nome da cena não foi definido no inspector!");
        }
    }
}