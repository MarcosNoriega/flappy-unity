using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaAudio : MonoBehaviour {
    public static SistemaAudio instance;
    public AudioClip AudioCoin;
    public AudioClip AudioHit;
    public AudioClip AudioFlappy;

    public AudioSource audioSouce;
    // Use this for initialization

    private void Awake()
    {
        if (SistemaAudio.instance == null)
        {
            SistemaAudio.instance = this;
        }else if (SistemaAudio.instance != this)
        {
            Destroy(gameObject);
        }
 
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        if (SistemaAudio.instance != this)
        {
            SistemaAudio.instance = null;
        }
    }

    public void playCoint()
    {
        audioSouce.clip = AudioCoin;
        audioSouce.Play();
    }

    public void playFlappy()
    {
        audioSouce.clip = AudioFlappy;
        audioSouce.Play();
    }

    public void playHit()
    {
        audioSouce.clip = AudioHit;
        audioSouce.Play();
    }
}
