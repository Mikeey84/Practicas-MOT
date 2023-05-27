using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region References
    /// <summary>
    /// Reference to player
    /// </summary>
    [SerializeField]
    private GameObject _player;
    /// <summary>
    /// Reference to UI Manager
    /// </summary>
    [SerializeField]
    private GameObject _UIManager;
    /// <summary>
    /// Reference to Level Manager
    /// </summary>
    [SerializeField]
    private GameObject _levelManager;
    #endregion
    #region properties
    /// <summary>
    /// True if the Game is running, False otherwise
    /// </summary>
    private bool _isGameRunning;
    /// <summary>
    /// Accesor to get the state of the game
    /// </summary>
    public bool IsGameRunning
    {
        get
        {
            return _isGameRunning;
        }
    }
    #endregion
    #region methods
    /// <summary>
    /// Method to send message Jump to player
    /// </summary>
    private void Jump()
    {
        _player.SendMessage("Jump");
    }
    /// <summary>
    /// Method to manage finalization of the game
    /// </summary>
    private InputComponent _myInputManager;
    private void OnPlayerDies()
    {
        _UIManager.SendMessage("GameOver");
        _levelManager.SendMessage("GameOver");
        gameObject.SendMessage("Stop");
        _myInputManager.enabled = false;
    }
    
    
        
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _isGameRunning = true;
        _myInputManager = GetComponent<InputComponent>();
    }

    
}   