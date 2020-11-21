using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador2 : MonoBehaviour {
    public GameObject bird;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Random.Range(0, 5) < 3)
        {
            if (bird.transform.position.y > transform.position.y)
            {
                transform.Translate(Vector2.up * 0.15f);
            }
            else
            {
                transform.Translate(Vector2.up * -0.15f);
            }
        }
        

        if (transform.position.y > 3.559f)
        {
            transform.position = new Vector2(transform.position.x, 3.559f);
        }
        else if(transform.position.y < -3.559f)
        {
            transform.position = new Vector2(transform.position.x, -3.559f);
        }
    }
    private void FixedUpdate()
    {
       
    }
}
