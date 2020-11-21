using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

    public int columnPoolSize = 5;
    public GameObject prefabColumnas;
    GameObject[] columnas;
    Vector2 posicionColumnas = new Vector2(-15, 0);

    float tiempo;
    float tiempoSpaw = 3f;

    float yMax = 1.4f;
    float yMin = -1.1f;
    float xcolumna = 10f;

    int turnoColumna;
	// Use this for initialization
	void Start () {
        columnas = new GameObject[columnPoolSize];

        for (int i = 0; i < columnPoolSize; i++) 
        {
            columnas[i] = Instantiate(prefabColumnas, posicionColumnas, Quaternion.identity);

            
        }
        spawColumnas();
    }
	
	// Update is called once per frame
	void Update () {
        tiempo += Time.deltaTime;

        if (!Controlador.instance.gameOver && tiempo >= tiempoSpaw)
        {
            tiempo = 0;
            spawColumnas();
        }
    }

    void spawColumnas()
    {
        float ycolumnas = Random.Range(yMin, yMax);
        columnas[turnoColumna].transform.position = new Vector2(xcolumna, ycolumnas);
        turnoColumna++;
        if (turnoColumna >= 5)
        {
            turnoColumna = 0;
        }
    }
}
