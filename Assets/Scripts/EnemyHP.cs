using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    int hp;
    public int maxHP = 2;

    public Slider sliderHP;

    public int HP
    {
        get { return hp;}
        set {
            hp = value;
            sliderHP.value = hp;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        sliderHP.maxValue = maxHP;
        HP = maxHP;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
