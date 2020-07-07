using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0;

    [SerializeField]
    private float variacaoY = 0;

    private Aviao aviao;

    private Pontuacao pontuacao;

    private bool pontuei;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));

    }

    private void Start()
    {
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
        aviao = GameObject.FindObjectOfType<Aviao>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);


        if (!pontuei && this.transform.position.x + 6 < aviao.transform.position.x)
        {
            Debug.Log("PosObstaculo: " + this.transform.position.x);
            Debug.Log("PosAviao: " + aviao.transform.position.x);
            Debug.Log("PONTUEI");
            pontuacao.AdicionarPonto();
            pontuei = true;
        }

    }

    void OnTriggerEnter2D(Collider2D wall)
    {
        if (wall.gameObject.tag == "wall")
        {
            Destroy(this.gameObject);
        }
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}
