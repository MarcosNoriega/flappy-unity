using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovil : MonoBehaviour {

    Rigidbody2D R_body = new Rigidbody2D();
    // Use this for initialization

    private void Awake()
    {
        R_body = GetComponent<Rigidbody2D>();
    }
    void Start() {
        R_body.velocity = new Vector2(Controlador.instance.SpeedScroll, 0);
    }

    // Update is called once per frame
    void Update() {
        if (Controlador.instance.gameOver)
        {
            R_body.velocity = Vector2.zero;
        }
    }

}
