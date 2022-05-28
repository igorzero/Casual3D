using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public GameObject jogador;
    private Vector3 distancia;

    void Start()
    {
        distancia = transform.position - jogador.transform.position;    
    }

    void LateUpdate()
    {
        transform.position = jogador.transform.position + distancia;   
    }
}
