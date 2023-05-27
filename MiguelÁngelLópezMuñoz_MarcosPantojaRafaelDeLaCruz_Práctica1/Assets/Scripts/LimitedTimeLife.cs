using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedTimeLife : MonoBehaviour
{
    #region paramaters
    /// <summary>
    /// Maximum time before the script destroys the object
    /// </summary>
    [SerializeField]
    private float _maxLifetime;
    #endregion
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
