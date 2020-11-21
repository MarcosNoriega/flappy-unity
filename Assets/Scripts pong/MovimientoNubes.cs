using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNubes : MonoBehaviour {
    Rigidbody2D rb2d;
    BoxCollider2D BoxCollider;
    float tamanoFondo;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        BoxCollider = GetComponent<BoxCollider2D>();
    }
    // Use this for initialization
    void Start () {
        rb2d.velocity = new Vector2(0.5f, 0);
        tamanoFondo = BoxCollider.size.x;

    }
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > tamanoFondo)
        {
            transform.Translate(Vector2.left * 2 * tamanoFondo);
        }
	}
}
