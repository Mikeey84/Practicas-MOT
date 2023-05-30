using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeComponent : MonoBehaviour
{
    #region references
    /// <summary>
    /// Reference to Game Manager object
    /// </summary>
    [SerializeField]
    private GameObject _gameManager;
    
    #endregion
    #region methods
    /// <summary>
    /// Executed on collision. The component informs GameManger of its death before
    /// destroying itself.
    /// </summary>
    /// <param name="collision">Colliding element collision</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PolygonCollider2D>())
        {
            GameManager.Instance.OnPlayerDies();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //_gameManager.SendMessage("OnPlayerDies");
            Destroy(gameObject);
        }
        
    }
    #endregion
}
