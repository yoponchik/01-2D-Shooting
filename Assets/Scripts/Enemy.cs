using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;
    public GameObject enemyBody;
    public GameObject explosionFactory;


    void Start()
    {
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

        if (other.gameObject.name.Contains("Bullet")){   //find the bullets
            Destroy(other.gameObject); //destroy the bullets/    
            Destroy(this.gameObject); //destroy the enemy

            GameObject GOScoreManager = GameObject.Find("ScoreManager");
            ScoreManager sc = GOScoreManager.GetComponent<ScoreManager>();

            sc.score++;
            sc.textScore.text = "Score: " + sc.score.ToString();

        }

        else if (other.gameObject.name.Contains("Player")) {
            Destroy(other.gameObject);
        }
    }
}
