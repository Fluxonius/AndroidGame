
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool lost = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy") { 
        lost = true; }
        
    }
}
