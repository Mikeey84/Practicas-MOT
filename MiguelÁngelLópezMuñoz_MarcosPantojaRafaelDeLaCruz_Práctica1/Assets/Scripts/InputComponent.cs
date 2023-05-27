using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputComponent : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SendMessage("Jump");
        }
    }
    void stop()
    {
        this.enabled = false; 
    }
}
