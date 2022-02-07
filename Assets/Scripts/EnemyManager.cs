using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public GameObject enemyFactory;
    public Transform enemyParent;

    public float createTime = 1;   //time to create the enemy
    float currentTime;
    

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;    //update the currentTime

        if (currentTime > createTime) {   //if the currentTime elapses past the createTime

            currentTime = 0;              //reset currentTime
                                          //otherwise the enemies will spawn in the same location and collide with each other
                                          //which mean they'll destroy themselves
            if (!GameManager.instance.gameOverUI.activeSelf) {  //b/c when the player dies, we dont want to have an error where the enemy cant find the player.
                GameObject enemy = Instantiate(enemyFactory);    //declare a new gameobject called enemy; instantiate the enemy
                enemy.transform.position = transform.position;   //give the enemy's position the same value as this GO
                enemy.transform.parent = enemyParent;            //make the enemy GO's parent enemyParent       

            }
        }   
    }
}
