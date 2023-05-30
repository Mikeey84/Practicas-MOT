using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootball : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _velocity;
    [SerializeField] private float _damage;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * _velocity * Time.deltaTime);


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<LateralMovementComponent>())
        {
            Destroy(other.gameObject);
            Destroy(this);
        }
    }
}
