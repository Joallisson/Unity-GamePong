using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        float speedX = Random.Range(0, 2) == 0 ? -1 : 1;  //-1 leva a bola para esquerda inicialmente e, 1 leva a bola pra direita
        float speedY = Random.Range(0, 2) == 0 ? -1 : 1;   //-1 leva a bola para baixo inicialmente e, 1 leva a bola pra cima

        GetComponent<Rigidbody>().velocity = new Vector3(speed * speedX, speed * speedY, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
