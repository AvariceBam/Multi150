using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int even = 22;
        while (even != 102) 
        {
            print(even);
                even = even + 2;
        }
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
