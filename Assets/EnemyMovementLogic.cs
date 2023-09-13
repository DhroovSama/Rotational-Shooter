using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementLogic : MonoBehaviour
{
    public float enemySpeed = 0.5f;
    public GameObject particles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemyToPlayer();
    }

    void moveEnemyToPlayer()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(0, 0, 0), enemySpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D transformCollision)
    {
        if (transformCollision.gameObject.tag == "Projectile")
        {
            spawnParticles(transformCollision.transform.position);
            Destroy(transformCollision.gameObject);
        }
    }

    void spawnParticles(Vector2 tempPosition)
    {
        Instantiate(particles, tempPosition, Quaternion.identity);
    }
}
