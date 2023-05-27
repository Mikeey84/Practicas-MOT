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

    private SpawnPointsComponent _mySpawnPointsComponent;
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
    public void Stop()
    {
        this.enabled = false;
    }
    #endregion
    // Update is called once per frame
    private void Start()
    {
        _mySpawnPointsComponent = GetComponent<SpawnPointsComponent>();
    }
    void Update()
    {
        int _myRandomObstacle = Random.Range(0, _prefabs.Length);
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _nextSpawnTime)
        {
            Instantiate(_prefabs[_myRandomObstacle], _spawnTransform.position, Quaternion.identity);
            _nextSpawnTime = Random.Range(_minTimeInterval, _maxTimeInterval);
            _elapsedTime = 0;
            _mySpawnPointsComponent.Points();
        }

    }
}
