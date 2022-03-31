using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    #region Declaration

    public float speed = 5;
    Vector3 dir;
    public GameObject enemyBody;
    public GameObject explosionFactory;

    EnemyHP enemyHP;

    #endregion Declaration

    void Start()
    {
        enemyHP = GetComponent<EnemyHP>();

        float result = Random.Range(0, 10);
        if (result < 3) {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();
            enemyBody.transform.rotation = Quaternion.FromToRotation(Vector3.up, dir);
        }
        else {
            dir = Vector3.down;
            enemyBody.transform.eulerAngles = new Vector3(0, 0, 180);
        }
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other) {


        enemyHP.HP--; //if hit by anything, decrease health

        if (other.gameObject.CompareTag("Bullet")){   //find the bullets
            Destroy(other.gameObject); //destroy the bullets/    

            //GameObject GOScoreManager = GameObject.Find("ScoreManager");
            //ScoreManager sc = GOScoreManager.GetComponent<ScoreManager>();

            //sc.SetScore(sc.GetScore() + 1); //for using regular GetScore SetScore functions

            //ScoreManager.instance.SCORE++;                       //using property and Singleton
        }

        if (enemyHP.HP <= 0) {
            if (other.gameObject.name.Contains("Bullet")) {
                ScoreManager.instance.SCORE++;
            }
            GameObject explosion = Instantiate(explosionFactory);
            explosion.transform.position = transform.position;

            Destroy(this.gameObject); //destroy the enemy
        }

        if (other.gameObject.CompareTag("Player")) {
            //GameOver
            Destroy(other.gameObject);
            GameManager.instance.gameOverUI.SetActive(true);
            Time.timeScale = 0.2f;
        }
    }
}
