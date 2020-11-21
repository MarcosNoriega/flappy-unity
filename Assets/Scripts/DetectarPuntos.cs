using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarPuntos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            SistemaAudio.instance.playCoint();
            Controlador.instance.sumarPuntos();
        }
    }



}
