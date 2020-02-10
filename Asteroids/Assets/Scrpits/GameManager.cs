using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int lives = 3;
    public int score = 0;
    public bool isPaused = false;
    public GameObject playerPrefab;
    public GameObject Player;
    public GameObject asteroidPrefab;
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;
    public GameObject enemy3Prefab;
    public List<GameObject> enemiesList = new List<GameObject>();

    public void  Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            Debug.LogError("I tried to create a second Game Manager");
        }
        
    }

    public void Start()
    {
        Instantiate(enemy1Prefab);
        Instantiate(enemy2Prefab);
        Instantiate(enemy3Prefab);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Application.Quit();
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(asteroidPrefab);
        }
    }

    public void Respawn()
    {
       Player =  Instantiate(playerPrefab);
       
    }

    public void EnemyRespawn()
    {
         Instantiate(enemy1Prefab);
    }

}

