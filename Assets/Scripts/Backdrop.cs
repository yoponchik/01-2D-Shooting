using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backdrop : MonoBehaviour
{
    Material backdropMaterial;
    public float scrollSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
        backdropMaterial = renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        backdropMaterial.mainTextureOffset += Vector2.up * scrollSpeed * Time.deltaTime;
    }
}
