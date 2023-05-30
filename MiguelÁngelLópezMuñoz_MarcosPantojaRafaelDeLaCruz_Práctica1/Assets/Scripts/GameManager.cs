using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region References
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }
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
    private ObstacleGenerator _obstacleGenerator;
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
    public float _points;
    #endregion
    #region methods
    /// <summary>
    /// Method to send message Jump to player
    /// </summary>
    public void Jump()
    {
        //_player.SendMessage("Jump");
        _player.GetComponent<MovementComponent>().Jump();
    }
    /// <summary>
    /// Method to manage finalization of the game
    /// </summary>
    private InputComponent _myInputManager;
    public void OnPlayerDies()
    {
        _isGameRunning = false;

        //_UIManager.SendMessage("GameOver");
        _UIManager.GetComponent<UIManager>().GameOver();
        //_levelManager.SendMessage("GameOver");
        _levelManager.GetComponent<LevelManager>().GameOver();
        //gameObject.SendMessage("Stop");
        _obstacleGenerator.Stop();
        _myInputManager.enabled = false;
    }
    public void Awake()
    {
        _instance = this;
    }
    public void PointsSum()
    {
        _points++;
        Debug.Log(_points);
    }



    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _isGameRunning = true;
        _myInputManager = GetComponent<InputComponent>();
        _obstacleGenerator = GetComponent<ObstacleGenerator>();
        _points = 0;
        Debug.Log(_points);
    }

    
}   