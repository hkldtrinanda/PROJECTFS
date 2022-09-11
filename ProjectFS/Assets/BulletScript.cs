using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public int damage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Target")
        {
            other.GetComponent<flameScript>().TakeDamage(damage);
        }
    }
    void destroySelf()
    {
        gameObject.SetActive(false);
    }
}
