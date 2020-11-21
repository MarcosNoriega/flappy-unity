using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorPong : MonoBehaviour {
    public static ControladorPong instance;
    public static int ptosJ1;
    public static int ptosJ2;
    public Text ptosJ1Text;
    public Text ptosJ2Text;
    // Use this for initialization
    void Start () {
        ptosJ1Text.text = ptosJ1.ToString();
        ptosJ2Text.text = ptosJ2.ToString();
        if (ControladorPong.instance == null)
        {
            ControladorPong.instance = this;
        }
        else if(ControladorPong.instance != this)
        {
            Destroy(this);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void sumarPtosJ1()
    {
        ptosJ1++;
        ptosJ1Text.text = ptosJ1.ToString();



        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void sumarPtosJ2()
    {
        ptosJ2++;
        ptosJ2Text.text = ptosJ2.ToString();



        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void OnDestroy()
    {
        if (ControladorPong.instance == this)
        {
            ControladorPong.instance = null;
        }
    }
}
