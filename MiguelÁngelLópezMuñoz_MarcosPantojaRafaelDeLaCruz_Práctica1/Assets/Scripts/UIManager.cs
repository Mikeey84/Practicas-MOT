using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    #region references
    /// <summary>
    /// Reference to object containing GameOver text element
    /// </summary>
    [SerializeField]
    private GameObject _gameOverObject;

    float _pointsUI;

    public TextMeshProUGUI _uiText;

    #endregion
    #region methods
    /// <summary>
    /// Metrhod callled to activate the GameOver text element
    /// </summary>
    public void GameOver()
    {
        _gameOverObject.SetActive(true);
    }
    
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _gameOverObject.SetActive(false);
        _uiText = GetComponent<TextMeshProUGUI>();
        
        
    }
    private void Update()
    {
         
         _pointsUI = GameManager.Instance._points;
         _uiText.text = _pointsUI.ToString("0");

    }
}
