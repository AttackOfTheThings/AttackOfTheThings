using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public GameObject player;
    public Animator enemyAnimator;
    public float damage = 20f;
    public float enemyHealth = 100f;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player.transform.position;
        if(GetComponent<NavMeshAgent>().velocity.magnitude > 1)
        {
            enemyAnimator.SetBool("isRunning", true);
        }
        else
        {
            enemyAnimator.SetBool("isRunning", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == player)
        {
            Debug.Log("Eating");
            player.GetComponent<PlayerManager>().Hit(damage);
        }
    }

    public void Hit(float damageEnemy)
    {
        enemyHealth -= damageEnemy;
        if(enemyHealth <= 0)
        {
            gameManager.enemiesAlive--;
            Destroy(gameObject);
            Debug.Log("Died");
        }
        Debug.Log(enemyHealth);
    }
}
