using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStop : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public AudioClip background;
    public AudioClip gameOverSound;
    public AudioSource audioSource;
    private bool konec;

    void Start()
    {
        konec = false;
        audioSource.clip = background;
        audioSource.Play();
        
    }
    void Update()
    {
        if (Scoring.gameOver)
        {
            audioSource.clip = gameOverSound;
            audioSource.Play();
            enabled = false;
        }
    }



}
