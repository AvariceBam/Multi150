using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int BDay = 0; BDay <= 31; BDay=BDay+1)
        {
            if (BDay == 9)
            {
                Debug.Log("Its My Birthday!");
            }
            else
            {
                Debug.Log(BDay);
            };
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}    
