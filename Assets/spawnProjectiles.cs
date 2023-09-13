using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProjectiles : MonoBehaviour
{

    public GameObject projectile;
    public Vector3 localOffset = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getMouseClickDown();
    }

    void getMouseClickDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spawnTheProjectileVOID();
        }
    }

    void spawnTheProjectileVOID()
    {
        GameObject projectileClone;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        projectileClone = Instantiate(projectile, transform.TransformPoint(Vector3.left + localOffset), Quaternion.Euler(0, 0, transform.eulerAngles.z) );

        Rigidbody2D projectileRigidBody = projectileClone.AddComponent<Rigidbody2D>();
        projectileRigidBody.velocity = mousePosition * 4.0f;
        projectileRigidBody.gravityScale = 0;
    }
}
