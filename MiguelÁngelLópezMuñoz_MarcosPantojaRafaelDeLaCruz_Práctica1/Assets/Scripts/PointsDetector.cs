using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsDetector : MonoBehaviour
{
    [SerializeField]
    private LayerMask _pointsLayer;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PointsMovement>())
        {
            GameManager.Instance.PointsSum();
            Debug.Log("puntsum");
        }
    }
}
