using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{

    [SerializeField]
    private float tempoParaGerar = 0;
    [SerializeField]
    private GameObject obstaculo;

    private float cronometro;

    void Awake()
    {
        this.cronometro = this.tempoParaGerar;        
    }

    // Update is called once per frame
    void Update()
    {
        cronometro -= Time.deltaTime;

        if(cronometro < 0)
        {
            GameObject.Instantiate(obstaculo, this.transform.position, Quaternion.identity);
            cronometro = this.tempoParaGerar;
        }

    }
}
