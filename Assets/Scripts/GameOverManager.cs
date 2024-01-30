using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverText;
    public static GameOverManager gomSharedInstance;
    private void Awake()
    {
        if(gomSharedInstance == null)
        {
            gomSharedInstance = this;
        }
    }
    public IEnumerator GameOverCO()
    {
        gameOverText.SetActive(true);

        AudioManager.amSharedInstance.PlaySFX(1);

        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene(0);
    }
}
