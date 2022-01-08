using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;


    // Update is called once per frame
    void Update()
    {
        Vector3 dir = transform.up;
        transform.position += dir * speed * Time.deltaTime;
    }
}
