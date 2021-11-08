using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float health = 100f;
    public Text healthText;
    public GameManager gameManager;


    public void Hit(float damage)
    {
        health -= damage;
        healthText.text = "Health: " + health.ToString() + " %";
        if (health <= 0)
        {
            gameManager.GameOver();
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
}
