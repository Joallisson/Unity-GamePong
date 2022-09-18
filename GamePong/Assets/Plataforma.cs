using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float speed = 5f;
    private float  minY, maxY;
    public int maxDistancia, minDistacia;
    public bool isRight;

    private void Start() {
        SetMinAndMaxX();
    }

    // Update is called once per frame
    void Update()
    {
        VerificarMaxEMinDistacia();
    }

     private void SetMinAndMaxX() //delimitar espaço da camera para o chapeu percorrer
    {
        //atribuindo limites do safeArea para o mundo da unity. para delimitar o limite o espaço que o chapéu pode percorrer na teal horizontalmente
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f));
        maxY = bounds.y - maxDistancia;
        minY = -bounds.y + minDistacia;
    }

    private void VerificarMaxEMinDistacia()
    {
        if(Input.GetAxis("Vertical Direita") > 0 || Input.GetAxis("Vertical Esquerda") > 0) //Se for maior que o MaxY
        {
            if (transform.position.y < maxY)
            {
                MoveRquete();
            }
        }
        else if(Input.GetAxis("Vertical Direita") < 0 || Input.GetAxis("Vertical Esquerda") < 0)
        {
             if (transform.position.y > minY)
            {
                MoveRquete();
            }
        }
    }

    private void MoveRquete()
    {
        if(isRight)
        {
            transform.Translate(0f, Input.GetAxis("Vertical Direita") * speed, 0f);
        }else
        {
             transform.Translate(0f, Input.GetAxis("Vertical Esquerda") * speed, 0f);
        }
    }
}
