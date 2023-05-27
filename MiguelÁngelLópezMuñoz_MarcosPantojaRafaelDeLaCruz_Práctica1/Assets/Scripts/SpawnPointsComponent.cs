using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointsComponent : MonoBehaviour
{
    [SerializeField]
    private LayerMask _player;

    [SerializeField]
    private Transform _spawnTransform;

    [SerializeField]
    private GameObject _points;

    public void Points()
    {
        Instantiate(_points, _spawnTransform.position, Quaternion.identity);
    }
}
