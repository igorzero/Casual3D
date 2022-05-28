using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerScript : MonoBehaviour
{
    private Rigidbody rbJogador;
    private float movimentoX;
    private float movimentoY;
    private float velocidade = 15.0f;
    void Start()
    {
        rbJogador = GetComponent<Rigidbody>();
    }    
    
    void OnMove (InputValue valorMovimento)
    {
        Vector2 vetorMovimento = valorMovimento.Get<Vector2>();
        movimentoX = vetorMovimento.x;
        movimentoY = vetorMovimento.y;
    }    

    void FixedUpdate ()
    {
        Vector3 movimento = new Vector3(movimentoX, 0.0f, movimentoY);
        rbJogador.AddForce(movimento * velocidade);
    }
}

