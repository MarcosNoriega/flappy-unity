using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1 : MonoBehaviour {

    public float speed;
    Vector3 target;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = 0;
        target.x = transform.position.x;

        transform.position = target;

        if (transform.position.y > 3.559f)
        {
            transform.position = new Vector2(transform.position.x, 3.559f);
        }
        else if(transform.position.y < -3.559f)
        {
            transform.position = new Vector2(transform.position.x, -3.559f);
        }
	}
}
