using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get user Input
        float hori = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        //combine the input to get direction of GO(GameObject)
        Vector3 dir = Vector3.right * hori + Vector3.up * verti;
        //(1 0 0) * h =>  (h 0 0)
        //(0 1 0) * v => +(0 v 0)
        //(h v 0)
        //Vector3 dir = new Vector3(h, v, 0);

        //Normalize the direction: want to make all direction vectors 1 (b/c of diagonal ones)
        dir.Normalize();

        //move the GO
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
