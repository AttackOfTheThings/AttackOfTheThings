using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject playerCamera;
    public float weaponRange = 100f;
    public int weaponDamage = 50;
    public Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //turn off Shooting
        if(playerAnimator.GetBool("isShooting"))
        {
            playerAnimator.SetBool("isShooting", false);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            ShootWeapon();

        }
    }
    void ShootWeapon()
    {
        playerAnimator.SetBool("isShooting", true);
        RaycastHit hit;
        //(origin, directionTraveled, whatItHit, weaponRange)
        if(Physics.Raycast(playerCamera.transform.position, transform.forward, out hit, weaponRange))
        {
            EnemyManager enemyManager = hit.transform.GetComponent<EnemyManager>();
            if(enemyManager !=null)
            {
                enemyManager.Hit(weaponDamage);
            }
        }
    }

    
}
