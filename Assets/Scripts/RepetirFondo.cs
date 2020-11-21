using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetirFondo : MonoBehaviour {

    BoxCollider2D boxcoll;
    float tamanofondo;

    // Use this for initialization
    private void Awake()
    {
        boxcoll = GetComponent<BoxCollider2D>();
    }
    void Start () {
        tamanofondo = boxcoll.size.x;
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -tamanofondo)
        {
            transform.Translate(Vector2.right * tamanofondo * 2);
        }
	}
}
