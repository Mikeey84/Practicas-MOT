using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    [SerializeField] private Transform _Controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }
    }
    private void Shot()
    {
        Instantiate(_ball,_Controller.position, _Controller.rotation);
        
        
    }
}
