using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;
    public int highScore;

    public GameObject pinballPrefab;
    public GameObject ballSpawner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBall()
    {
        if (lives > 0)
        {
            Instantiate(pinballPrefab, ballSpawner.transform.position, ballSpawner.transform.rotation);
            lives--;
        }
    }
}
