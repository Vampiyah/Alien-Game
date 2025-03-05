using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    //the amount of damage the hazard does
    public int hazardDamage;


    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        //get the object we collide with
        Collider2D objectWeCollideWith = collisionData.collider;

        //player health script attached to the object
        PlayerHealth player = objectWeCollideWith.GetComponent<PlayerHealth>();

        //check if you actually found player health script
        if (player != null)
        {
            //perform our action to hurt the player
            player.ChangeHealth(-hazardDamage);
        }



    }
}    
      
