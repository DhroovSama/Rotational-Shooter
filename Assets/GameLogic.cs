using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    public float enemySpawnTimeFLOAT0 = 1.2f;
    public float enemySpawnTimeFLOAT1 = 2.1f;
    public float enemySpawnTimeFLOAT2 = 3.3f;
    public float enemySpawnTimeFLOAT3 = 1.5f;

    public GameObject enemyToSpawn;
    public bool canSpawn = true;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemySpawnTimer0());
        StartCoroutine(enemySpawnTimer1());
        StartCoroutine(enemySpawnTimer2());
        StartCoroutine(enemySpawnTimer3());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator enemySpawnTimer0()
    {
        while(canSpawn == true){
            spawnEnemy0();
            yield return new WaitForSeconds(enemySpawnTimeFLOAT0);
        }
    }
    

    IEnumerator enemySpawnTimer1()
    {
        while(canSpawn == true){
            spawnEnemy1();
            yield return new WaitForSeconds(enemySpawnTimeFLOAT1);
        }
    }


    IEnumerator enemySpawnTimer2()
    {
        while(canSpawn == true){
            spawnEnemy2();
            yield return new WaitForSeconds(enemySpawnTimeFLOAT2);
        }
    }


    IEnumerator enemySpawnTimer3()
    {
        while(canSpawn == true){
            spawnEnemy3();
            yield return new WaitForSeconds(enemySpawnTimeFLOAT3);
        }
    }

    void spawnEnemy0()
    {
        Instantiate(enemyToSpawn, new Vector3(-38, 18, 0), Quaternion.identity);
    }

    void spawnEnemy1()
    {
        Instantiate(enemyToSpawn, new Vector3(38, 18, 0), Quaternion.identity);
    }

    void spawnEnemy2()
    {
        Instantiate(enemyToSpawn, new Vector3(38, -18, 0), Quaternion.identity);
    }

    void spawnEnemy3()
    {
        Instantiate(enemyToSpawn, new Vector3(-38, -18, 0), Quaternion.identity);
    }
}
