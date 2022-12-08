using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemySpawner : MonoBehaviour
{
    [SerializeField]
    private int waveCount;
    //enemies to spawn in 
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private GameObject enemyBigPrefab;

    //interval of time between each enemy spawn
    [SerializeField]
    private float enemySpawnInterval = 3f;
    [SerializeField]
    private float enemyBigSpawnInterval = 10f;

    //keeps track of the time
    private float currentTime = 0f;
    private float currentTime1 = 0f;

    //amount of enemies to spawn in
    
    public int countEnemy = 10;
    [SerializeField]
    private int countBigEnemy = 5;

    //counters to keep track of the amount of eneimes that were spawned
    private int count = 0;
    private int countBig = 0;

    public List<GameObject> enemies;

    // Start is called before the first frame update
    void Start()
    {
        enemies = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //gets the the time
        currentTime += Time.deltaTime;
        currentTime1 += Time.deltaTime;

        //checks if the time is greater than the given spawn interval. If greater, then a new enemy is spawned and the counter is updated
        if(currentTime > enemySpawnInterval && countEnemy > count)
        {
            GameObject newEnemy = Instantiate(enemyPrefab, new Vector3(Random.Range(-10f, 10), 1, 0), Quaternion.identity);
            enemies.Add(newEnemy);
            currentTime = 0;
            count++;
        }

        if(currentTime1 > enemyBigSpawnInterval && countBigEnemy > countBig)
        {
            GameObject newEnemy = Instantiate(enemyBigPrefab, new Vector3(Random.Range(-10f, 10), 1, 0), Quaternion.identity);
            currentTime1 = 0;
            countBig++;
        }
    }
}
