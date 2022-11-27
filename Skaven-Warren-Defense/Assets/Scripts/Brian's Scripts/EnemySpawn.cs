using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private GameObject enemyBigPrefab;

    [SerializeField]
    private float enemySpawnInterval = 3f;
    [SerializeField]
    private float enemyBigSpawnInterval = 10f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemySpawnInterval, enemyPrefab));
        StartCoroutine(spawnEnemy(enemyBigSpawnInterval, enemyBigPrefab));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-10f, 10), 1, 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
