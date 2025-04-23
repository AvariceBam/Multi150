using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, moveY, 0);
        transform.Translate(move * speed * Time.deltaTime);
    }
}
