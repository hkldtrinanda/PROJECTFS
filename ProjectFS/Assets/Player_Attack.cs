using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{

    public static Player_Attack instance;
    public bool canShoot;
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float lastShootTime, fireRate;
    

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            Shoot();
        }
      
    
    }

    void Shoot()
    {
        if (Time.time > lastShootTime + fireRate)
        {
            GameObject NewBullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            NewBullet.SetActive(true);
            NewBullet.transform.localScale = transform.localScale;
        }
      
    }
}
