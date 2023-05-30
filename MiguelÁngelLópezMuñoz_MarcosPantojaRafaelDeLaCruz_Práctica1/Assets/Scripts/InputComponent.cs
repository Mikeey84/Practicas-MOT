using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputComponent : MonoBehaviour
{
    private float _cont;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //gameObject.SendMessage("Jump");
            GameManager.Instance.Jump();
        }
    }
    void stop()
    {
        this.enabled = false; 
    }

}
