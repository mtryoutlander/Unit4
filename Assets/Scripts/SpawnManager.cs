using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy, powerup;
    public int xRange, zRange;
    private int enemyCount;
    private int round = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy(1);
        SpawnPowerup();
    }
    private void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0)
        {
            round++;
            SpawnEnemy(round);
            SpawnPowerup();
        }
    }

    private void SpawnPowerup()
    {
        Instantiate(powerup, SpawnVector(), powerup.transform.rotation);
    }

    public void SpawnEnemy( int round)
    {
        for (int i = 0; i < round; i++)
        {
            Instantiate(enemy, SpawnVector(), enemy.transform.rotation);
        }
    }

    private Vector3 SpawnVector()
    {
        return new Vector3(Random.Range(-xRange, xRange), 0.2f, Random.Range(-zRange, zRange));
    }
}
