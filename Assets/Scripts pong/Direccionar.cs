using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direccionar : MonoBehaviour {
    public Vector2 direccion;
    public float velocidad;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("bird"))
        {
            Rigidbody2D rb = col.GetComponent<Rigidbody2D>();
            rb.velocity = direccion * velocidad;
        }
    }
}
