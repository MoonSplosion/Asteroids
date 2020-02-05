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

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Application.Quit();
        }
    }

    public void Respawn()
    {
        Instantiate(playerPrefab);
    }

}

