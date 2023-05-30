using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsMovement : MonoBehaviour
{
    [SerializeField]
    private float _maxLifetime;

    #region methods
    /// <summary>
    /// Destroys the associated game object
    /// </summary>
    private void SelfDestroy()
    {
        Destroy(gameObject);
    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SelfDestroy", _maxLifetime);
    }
}
