using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += new Vector3(speed * transform.localScale.x * Time.deltaTime, 0f, 0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}
