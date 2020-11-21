using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador : MonoBehaviour {
    public static Controlador instance;
    public GameObject gameOverText;
    public float SpeedScroll = -1.5f;
    public bool gameOver;
    public int puntos;
    public Text puntosTextos;
    // Use this for initialization
    void Awake()
    {
        if (Controlador.instance == null)
        {
            Controlador.instance = this;
        }else if (Controlador.instance != this)
        {
            Destroy(gameObject);
        }
        
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}

    public void birdDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    public void sumarPuntos()
    {
        if (gameOver) return;

        puntos += 1;
        puntosTextos.text = "Puntuación: " + puntos;
    }

    private void OnDestroy()
    {
        if (Controlador.instance == this)
        {
            Controlador.instance = null;
        }
    }
}
