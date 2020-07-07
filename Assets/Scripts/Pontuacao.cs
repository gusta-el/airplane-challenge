using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;
    private int score = 0;

    private AudioSource audioPontuacao;

    public void Awake()
    {
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }

    public void ReiniciarPontuacao()
    {
        score = 0;
        this.textoPontuacao.text = score.ToString();
    }

    public void AdicionarPonto()
    {
        this.score++;
        this.textoPontuacao.text = score.ToString();
        this.audioPontuacao.Play();

    }

}
