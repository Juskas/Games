using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemigosConteo: MonoBehaviour
{
    public static EnemigosConteo instance;

    private int totalEnemies;
    private int remainingEnemies;

    public GameObject nextLevelButton;

    void Awake()
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

    void Start()
    {
        SetTotalEnemiesForScene(SceneManager.GetActiveScene().buildIndex);
        remainingEnemies = totalEnemies;
        UpdateButtonVisibility();
    }

    void SetTotalEnemiesForScene(int sceneIndex)
    {
        switch (sceneIndex)
        {
            case 1:
                totalEnemies = 2;
                break;
            case 2:
                totalEnemies = 6;
                break;
            case 3:
                totalEnemies = 1;
                break;
            case 4:
                totalEnemies = 1;
                break;
        }
    }

    public void EnemyDied()
    {
        remainingEnemies--;
        UpdateButtonVisibility();
    }

    void UpdateButtonVisibility()
    {
        nextLevelButton.SetActive(remainingEnemies <= 0);
    }
}