using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{

    public static Player_Attack instance;
    public bool canShoot, cooldownEnd;
    public float shootCooldown = 1f;
    [SerializeField] Transform smoke;
    [SerializeField] GameObject bulletPrefab;
  
    

    private void Awake()
    {
        instance = this;
        cooldownEnd = true;
    }
    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1") && canShoot && cooldownEnd)
        {
            Shoot();
        }
      
    
    }

    void Shoot()
    {

        smoke.gameObject.SetActive(true);
            StartCoroutine(ShootCooldown());

     
      
    }

    IEnumerator ShootCooldown()
    {
        cooldownEnd = false;
        yield return new WaitForSeconds(shootCooldown);
        cooldownEnd = true;
    }
}
