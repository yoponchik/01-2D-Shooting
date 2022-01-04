using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;
    public GameObject body;

    void Start()
    {
        float result = Random.Range(0, 10);
        if (result < 3) {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();
            body.transform.rotation = Quaternion.FromToRotation(Vector3.up, dir);
        }
        else {
            dir = Vector3.down;
            body.transform.eulerAngles = new Vector3(0, 0, 100);
        }
    }

    void Update()
    {
        
    }
}
