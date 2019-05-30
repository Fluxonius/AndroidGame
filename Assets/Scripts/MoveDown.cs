
using UnityEngine;

public class MoveDown : MonoBehaviour
{[SerializeField]
    private float fallSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.5f)
            Destroy(gameObject);
        transform.position -= new Vector3(Random.Range(-2.5f,2.5f)*Time.deltaTime, fallSpeed * Time.deltaTime, 0);
    }
}
