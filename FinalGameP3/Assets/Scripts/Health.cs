using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public GameObject gameOverText;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            GameOver();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0;
    }
}
