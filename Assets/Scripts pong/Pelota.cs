using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour {
    Rigidbody2D rbd2;
    int velocidadX;
    int velocidadY;

    void Awake()
    {
        rbd2 = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    void Start() {
        transform.position = Vector2.zero;

        velocidadX = Random.Range(0, 2);
        if (velocidadX == 0)
        {
            velocidadX = 1;
        }
        else
        {
            velocidadX = -1;
        }

        velocidadY = Random.Range(0, 2);
        if (velocidadY == 0)
        {
            velocidadY = 1;
        }
        else
        {
            velocidadY = -1;
        }

        rbd2.velocity = new Vector2(velocidadX, velocidadY) * 5;
    }

    // Update is called once per frame
    void Update() {
        if (transform.position.x > 12)
        {
            ControladorPong.instance.sumarPtosJ2();

        } else if(transform.position.x < -12)
        {
            ControladorPong.instance.sumarPtosJ1();
        }
        
	}

    private void OnCollisionEnter2D()
    {
        if (rbd2.velocity.x < 10 && rbd2.velocity.y < 10)
            rbd2.velocity = rbd2.velocity * 1.1f;
        else
        {
            rbd2.velocity = rbd2.velocity * 0.6f;
        }

    }
}
