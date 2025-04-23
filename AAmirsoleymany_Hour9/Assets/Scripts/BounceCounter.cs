using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int bounceCount = 0;
  void OnCollisionEnter(Collision collision)
    {
        bounceCount++;
        Debug.Log("Bounce #" + bounceCount);
    }
}
