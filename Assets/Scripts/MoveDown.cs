
using UnityEngine;

public class MoveDown : MonoBehaviour
{[SerializeField]
    private float fallSpeed = 0.5f;
   /* void Update()
    {
       // transform.Translate(Input.acceleration.x, -fallSpeed * Time.deltaTime, 0);
        
      // transform.position -= new Vector3(Mathf.Clamp(Input.acceleration.x, -2.3f, 2.3f), fallSpeed * Time.deltaTime, 0);
   }*/
    float dirX;

     Rigidbody2D rb;
     void Start()
     {
         rb = GetComponent<Rigidbody2D>();
     }
     void Update()
    {
        
        

            dirX = Input.acceleration.x * 0.5f;
            transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2.5f, 2.5f), transform.position.y);
        }

     
     void FixedUpdate()
     {
        
            rb.velocity -= new Vector2(-dirX,Time.deltaTime);
     }
}
