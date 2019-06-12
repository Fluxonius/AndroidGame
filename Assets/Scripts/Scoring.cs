using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static int score;
   // public GameObject restart;
    public static bool gameOver = false;
   
   // Animator anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
            if (collision.gameObject.tag == "Portal")
            {
                if (!gameOver) score++;
                Destroy(gameObject);
                //restart.SetActive(true);
            }
            if (collision.gameObject.tag == "Saw")
            {
                //anim.SetTrigger("Death");
                Destroy(gameObject);
                gameOver = true;
         

            
           


            }
        
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
