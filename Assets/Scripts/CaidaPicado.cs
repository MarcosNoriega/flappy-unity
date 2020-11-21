using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaPicado : MonoBehaviour {
    public float maxVelocidad = -5f;
    public float maximoAngulo = -90f;


    Rigidbody2D R_body = new Rigidbody2D();

    void Awake()
    {
        R_body = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (R_body != null) {
            float cortarVelocidad = Mathf.Clamp(R_body.velocity.y, maxVelocidad, 0);
            float angulo = (cortarVelocidad / maxVelocidad) * maximoAngulo;
            Quaternion rotacion = Quaternion.Euler(0, 0, angulo);
            transform.rotation = rotacion;
        }
	}
}
