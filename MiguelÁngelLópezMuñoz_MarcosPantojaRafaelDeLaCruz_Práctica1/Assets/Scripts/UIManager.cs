using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    #region references
    /// <summary>
    /// Reference to object containing GameOver text element
    /// </summary>
    [SerializeField]
    private GameObject _gameOverObject;
    #endregion
    #region methods
    /// <summary>
    /// Metrhod callled to activate the GameOver text element
    /// </summary>
    private void GameOver()
    {
        _gameOverObject.SetActive(true);
    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _gameOverObject.SetActive(false);
    }
}
