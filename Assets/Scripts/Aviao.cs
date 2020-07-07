using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{

    private Rigidbody2D fisica;
    private Diretor diretor;
    private Vector3 posicaoInicial;

    [SerializeField]
    private float forcaImpulso;

    
    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.fisica = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            this.Impulsionar();

    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * forcaImpulso, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D obstaculo)
    {
        diretor.FinalizarJogo();
    }

    public void ReiniciarAviao()
    {
        this.transform.position = this.posicaoInicial;

    }
}
