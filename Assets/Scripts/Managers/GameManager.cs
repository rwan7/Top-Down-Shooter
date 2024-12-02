using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public GameObject playerPrefab;
    public GameObject activePlayer;
	
	public ScriptableInteger life;
	public ScriptableInteger coin;
	public EnemySpawner spawner;
	
	public bool isPlaying = false;

	public UnityAction OnGameOverAction;
	
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GameManager.GetInstance().OnGameOverAction += GameOver;
    }

    public static GameManager GetInstance()
    {
        return instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnPlayer()
    {
        activePlayer = Instantiate(playerPrefab);
    }

    public Vector3 getPlayerPosition()
    {
        if (activePlayer != null)
        {
            return activePlayer.transform.position;
        }

        return Vector3.zero;
    }
	
	public void StartGame()
	{
		isPlaying = true;
		spawnPlayer();
	}
	
	public void PauseGame()
	{
		isPlaying = false;
		Time.timeScale = 0;
	}
	
	internal void RestartGame()
	{
		life.reset();
		coin.reset();
		spawner.ClearEnemies();
		ObjectPool.GetInstance().DeactivateAllObjects();
	}
	
	public void ResumeGame()
	{
		isPlaying = true;
		Time.timeScale = 1;
	}
	
	public void GameOver()
	{
		isPlaying = false;
		OnGameOverAction?.Invoke();
	}
}
