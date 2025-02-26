using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // unity editor variable which will hold the prefab reference
    public GameObject projectilePrefab;

    public Vector2 projectVelocity;

    public void FireProjectile()
    {
        //clone the projectile

        GameObject clonedProjectile;

        // use the instantiate function to clone
        clonedProjectile = Instantiate(projectilePrefab);

        //position projectile on player 
        clonedProjectile.transform.position = transform.position;

        // fire it in a direction
        Rigidbody2D projectileRigidbody;

        //get the projectile in rigidbody
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();

        // setting the velocity on the rigidbody to be set int he unity editor
        projectileRigidbody.velocity = projectVelocity;
    }

}
