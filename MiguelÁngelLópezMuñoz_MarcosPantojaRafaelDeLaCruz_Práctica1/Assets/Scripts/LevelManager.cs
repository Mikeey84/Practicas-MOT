using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private Parallax _parallax;
    #region methods
    /// <summary>
    /// Stops the paralax scrollers
    /// </summary>
    public void GameOver()
    {
        for(int i = 0; i < 6; i++)
        {
            transform.GetChild(i).GetComponent<Parallax>().SendMessage("Stop");
        }
    }
    #endregion
}
