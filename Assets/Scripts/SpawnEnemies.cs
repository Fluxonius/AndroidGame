using System.Collections;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy;

    private void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (!Player.lost)
        {
            Instantiate(enemy, new Vector2(Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);

        }
    }

}
