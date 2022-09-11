using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flameScript : MonoBehaviour
{
    public int healthPoint, maxHealthPoint, score = 100;

    private void Start()
    {

        healthPoint = maxHealthPoint;
    }

    public void TakeDamage(int damage)
    {
        healthPoint -= damage;
        if(healthPoint <= 0)
        {
            healthPoint = 0;
            Destroy(gameObject);
            LeverScripting.instance.jumlahApiPadam += 1;
            ScoreManager.instance.AddScore(score);
        }
    }



}
