using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{
    ScoreLogic addToScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D transformCollision)
    {
        if (transformCollision.gameObject.tag == "Enemy")
        {
            callScoreLogicScript();
            Destroy(transformCollision.gameObject);
        }
    }

    void callScoreLogicScript()
    {
        addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>() ;
        addToScore.addToScoreVOID();
    }
}
