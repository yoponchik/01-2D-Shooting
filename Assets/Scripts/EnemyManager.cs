using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public GameObject enemyFactory;
    public Transform enemyParent;

    public float createTime;   //time to create the enemy
    float currentTime;
    

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;    //update the currentTime

        if (currentTime > createTime) {   //if the currentTime elapses past the createTime

            currentTime = 0;              //reset currentTime

            GameObject enemy = Instantiate(enemyFactory);    //declare a new gameobject called enemy; instantiate the enemy
            enemy.transform.position = transform.position;   //give the enemy's position the same value as this GO
            enemy.transform.parent = enemyParent;            //make the enemy GO's parent enemyParent       
                                                            //otherwise the enemies will spawn in the same location and collide with each other
                                                            //which mean they'll destroy themselves
        }   
    }
}
