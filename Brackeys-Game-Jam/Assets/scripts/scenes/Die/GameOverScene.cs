using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameOverScene : MonoBehaviour
{
    public string cenaParaCarregar = "GameOver";
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player == null)
        {
            Debug.LogWarning("Player foi destruído! Indo para a cena: " + cenaParaCarregar);
            SceneManager.LoadScene(cenaParaCarregar);
        }
    }
}