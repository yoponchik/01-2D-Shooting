using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    public Transform player = null;
    public float speed = 4;


    // Update is called once per frame
    void Update()
    {
        Vector3 dir = player.position - transform.position;
        dir.Normalize();
        transform.position += dir * speed * Time.deltaTime;
    }
}
