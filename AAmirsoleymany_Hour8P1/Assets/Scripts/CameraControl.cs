using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    
   // This is the game object you want to access
   public GameObject objectYouWant;
    // This is here for reference
    void Start()
    {

    }
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal !> 0)
            objectYouWant.transform.Translate(.0f + mxVal, 0f, 0f);
        if (mxVal !< 0)
            objectYouWant.transform.Translate(.0f + mxVal, 0f, 0f);
        if (myVal !> 0)
            objectYouWant.transform.Translate(0f, 0f + myVal, 0f);
        if (myVal !< 0)
            objectYouWant.transform.Translate(0f, 0f + myVal, 0f);
    }
    
}