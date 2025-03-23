using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health;
        float poisonDamage;
        health = 1004f;
        poisonDamage = 125.5f;
        print(health);
        while (health > 0f) 
        {
            health = health - poisonDamage;
            print(health);
        };
        if (health <= 0f) 
        {
            Debug.Log("Player has been unalived");
        }
      
        //why was this so needlessly difficult??? its just following instructions lol
    }
    // Update is called once per frame
    void Update()
    {

    }
}