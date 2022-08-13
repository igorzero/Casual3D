using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
    private Rigidbody rbJogador;
    private float movimentoX;
    private float movimentoY;
    private float velocidade = 15.0f;
    public Text placar;
    private int pontos;

    void Start()
    {
        rbJogador = GetComponent<Rigidbody>();
        pontos = 0;
        ContagemDosPontos();
    }

    void ContagemDosPontos()
    {
        placar.text = "Pontos: " + pontos.ToString();
    }

    void OnMove(InputValue valorMovimento)
    {
        Vector2 vetorMovimento = valorMovimento.Get<Vector2>();
        movimentoX = vetorMovimento.x;
        movimentoY = vetorMovimento.y;
    }

    void FixedUpdate()
    {
        Vector3 movimento = new Vector3(movimentoX, 0.0f, movimentoY);
        rbJogador.AddForce(movimento * velocidade);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("moeda"))
        {
            other.gameObject.SetActive(false);
            pontos = pontos + 1;
            ContagemDosPontos();
        }
    }
}