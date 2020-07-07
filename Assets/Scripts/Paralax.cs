using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField]
    private float velocidade;
    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagem;

    void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.x;
        this.tamanhoRealDaImagem = tamanhoDaImagem * this.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoRealDaImagem);
        this.transform.position = this.posicaoInicial + (Vector3.left * deslocamento);

    }
}
