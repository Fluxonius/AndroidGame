using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy;
    public GameObject restart;
    public Text scoreText;
    void Awake()
    {
        Scoring.score = 0;
        Scoring.gameOver = false;
    }
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    private void Update()
    {
        scoreText.text = "SCORE:"+Scoring.score;
    }
    IEnumerator Spawn()
    {
        while (!Scoring.gameOver)
        {
            Instantiate(enemy, new Vector2(Random.Range(-2.3f, 2.3f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
           

        }
        restart.SetActive(true);
    }

}
