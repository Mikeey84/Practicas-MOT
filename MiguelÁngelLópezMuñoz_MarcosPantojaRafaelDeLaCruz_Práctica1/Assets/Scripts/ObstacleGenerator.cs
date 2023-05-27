using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    #region references
    /// <summary>
    /// Array of prefabs to instantiate as obstacles
    /// </summary>
    [SerializeField]
    private GameObject[] _prefabs;
    /// <summary>
    /// Reference to transform where obstacles will be instantiated
    /// </summary>
    [SerializeField]
    private Transform _spawnTransform;
    #endregion
    #region paramaters
    /// <summary>
    /// Maximum time between obstacles generation
    /// </summary>
    [SerializeField]
    private float _maxTimeInterval = 5.0f;
    /// <summary>
    /// Minimum time between obstacles generation
    /// </summary>
    [SerializeField]
    private float _minTimeInterval = 1.0f;
    #endregion
    #region properties
    /// <summary>
    /// Elapsed time since last obstacle generation
    /// </summary>
    private float _elapsedTime = 0;
    /// <summary>
    /// Time interval set for next obstacle generation
    /// </summary>
    private float _nextSpawnTime;
    #endregion
    #region methods
    /// <summary>
    /// Method to disable the script and thus stop obsctacles generation
    /// </summary>
    private void Stop()
    {
        this.enabled = false;
    }
    #endregion
    // Update is called once per frame

    void Update()
    {
        int _myRandomObstacle = Random.Range(0, _prefabs.Length);
        _elapsedTime += Time.deltaTime;
        _nextSpawnTime = Random.Range(_minTimeInterval, _maxTimeInterval + 1);
        if (_elapsedTime >= _nextSpawnTime)
        {
            Instantiate(_prefabs[_myRandomObstacle], _spawnTransform.position, Quaternion.identity);
            _elapsedTime = 0;
        }

    }
}
