using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Target")
        {
            
            other.gameObject.SetActive(false);
        }
    }
    void destroySelf()
    {
        gameObject.SetActive(false);
    }
}
