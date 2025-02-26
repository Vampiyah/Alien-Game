using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            KillEnemy(collision.gameObject);
            Destroy(gameObject);
        }  
    }


    public void KillEnemy(GameObject Enemy)
    {
        Destroy(Enemy);
    }
}
