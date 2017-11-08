using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public GameObject gameHUD;
    public GameObject menuPause;
    public GameObject menuGameOver;
    public GameObject menuGameWin;

    private bool isPause;

    private void Awake()
    {
        Time.timeScale = 1;
    }
        
    void Start () {

        isPause = false;

        menuPause.SetActive(false);
        menuGameOver.SetActive(false);
        menuGameWin.SetActive(false);

	}
	
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            PauseManager();
        }		
	}

    private void PauseManager()
    {
        isPause = !isPause;

        if (isPause)
        {
            OnPaused();
        }else
        {
            OnResume();
        }
    }

    private void OnPaused()
    {
        menuPause.SetActive(true);
        gameHUD.SetActive(false);
        Time.timeScale = 0;
    }

    private void OnResume()
    {
        menuPause.SetActive(false);
        gameHUD.SetActive(true);
        Time.timeScale = 1;
    }

    public void OnGameOver()
    {
        menuGameOver.SetActive(true);
        gameHUD.SetActive(false);
        Time.timeScale = 0;
    }

    public void OnGameWin()
    {
        menuGameWin.SetActive(true);
        gameHUD.SetActive(false);
    }

    public void Resume()
    {
        OnResume();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Sair()
    {
        SceneManager.LoadScene("Intro");
    }
}
