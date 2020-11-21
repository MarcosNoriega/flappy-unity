using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

	Rigidbody2D R_body = new Rigidbody2D();
    bool muerto = false;
    public float fuerza = 200f;
    Animator ani = new Animator();

    CaidaPicado caidapicado;
	// Use this for initialization

	void Awake(){
        R_body = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        caidapicado = GetComponent<CaidaPicado>();
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (muerto) return;

		if (Input.GetMouseButtonDown(0)) {
            R_body.velocity = Vector2.zero;
            R_body.AddForce(Vector2.up * fuerza);
            ani.SetTrigger("aletear");
            SistemaAudio.instance.playFlappy();
		}
		
	}

    void OnCollisionEnter2D()
    {
        muerto = true;
        ani.SetTrigger("muerto");
        caidapicado.enabled = false;
        SistemaAudio.instance.playHit();
        Invoke("BirdDie", 1f);
        
    }

    void BirdDie()
    {
        Controlador.instance.birdDie();
    }
}
