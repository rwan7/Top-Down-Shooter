using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
	public InputHandler inputHandler;
	
	public GameObject mainMenu;
	public GameObject pauseMenu;
	public GameObject gameOverMenu;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void StartGame()
	{
		mainMenu.SetActive(false);
	}
	
	public void PauseGame()
	{
		pauseMenu.SetActive(true);
		GameManager.GetInstance().PauseGame();
	}
	
	public void ResumeGame()
	{
		pauseMenu.SetActive(false);
		GameManager.GetInstance().ResumeGame();
	}
	
	public void QuitGame()
	{
		Application.Quit();
	}
	
	public void GameOver()
	{
		gameOverMenu.SetActive(true);
	}
	
	public void RestartGame()
	{
		gameOverMenu.SetActive(false);
		mainMenu.SetActive(true);
		GameManager.GetInstance().RestartGame();
	}
	
	private void OnEnable()
	{
		inputHandler.OnPauseAction += PauseGame;
	}
	
	private void OnDisable()
	{
		inputHandler.OnPauseAction -= PauseGame;
	}
}
